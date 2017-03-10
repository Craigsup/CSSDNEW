using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModifiedTicketingSystem {
    [Serializable]
    public class Station {
        protected DepartureList _departureList;
        protected List<Ticket> _validTicketList;
        protected readonly string _location;

        public Station(DepartureList departureList, string location) {
            _departureList = departureList;
            _location = location;
            _validTicketList = ReadFromBinaryFile<List<Ticket>>(@_location + "_tickets.txt");
        }

        public Station(string Location) {
            _location = Location;
            _validTicketList = ReadFromBinaryFile<List<Ticket>>(@_location + "_tickets.txt");
        }

        public DepartureList GetDepartures() {
            return _departureList;
        }

        public string GetLocation() {
            return _location;
        }

        public Ticket GetTicketByTicketId(int ticketId) {
            Ticket aTicket = new Ticket();
            //check if it is a single ticket
            var singleTickets = ReadFromBinaryFile<List<Ticket>>(@_location + "_tickets.txt");

            foreach (var ticket in singleTickets) {
                if (ticket.GetTicketId() == ticketId) {
                    return ticket;
                }
            }
            //check if it is a timed ticket
            var timedTickets = ReadFromBinaryFile<List<Ticket>>(@"Tickets.txt");

            foreach (var ticket in timedTickets) {
                if (ticket.GetTicketId() == ticketId) {
                    return ticket;
                }
            }
            //not used
            return aTicket;
        }

        public void InitialiseTicketList(Ticket ticket) {
            _validTicketList = new List<Ticket>();
            _validTicketList.Add(ticket);
            WriteToBinaryFile(@_location + "_tickets.txt", _validTicketList, false);
        }

        public void AddTicketToList(Ticket ticket) {
            ticket.InitialiseTicketId();
            _validTicketList = ReadFromBinaryFile<List<Ticket>>(@_location + "_tickets.txt");
            _validTicketList.Add(ticket);
            WriteToBinaryFile(@_location + "_tickets.txt", _validTicketList, false);
        }

        public void RemoveTicketFromList(Ticket ticket) {
            _validTicketList = ReadFromBinaryFile<List<Ticket>>(@_location + "_tickets.txt");
            foreach(var tick in _validTicketList) {
                if(tick.GetTicketId() == ticket.GetTicketId()) {
                    _validTicketList.Remove(tick);
                    break;
                }
            }
            WriteToBinaryFile(@_location + "_tickets.txt", _validTicketList, false);
        }

        public void RemoveTimedTicketFromList(Ticket ticket) {
            var tickets = ReadFromBinaryFile<List<Ticket>>(@"Tickets.txt");
            tickets.Remove(ticket);
            WriteToBinaryFile(@"Tickets.txt", tickets, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>(T)binaryFormatter.Deserialize(stream)</returns>
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// This method takes the List of CustomerAccount object and binary serializes it, allowing the persistence of data.
        /// </summary>
        /// <param name="filePath">This is the file name/output directory.</param>
        /// <param name="objectToWrite">This is the object that gets serialized. Can be of any type.</param>
        /// <param name="append">This flags whether to append the object to the end of the file (if it exists already)</param>
        /// <typeparam name="T">This is the type of T</typeparam>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }
    }
}
