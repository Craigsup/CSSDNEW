using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModifiedTicketingSystem {
    public class StationList {
        private List<Station> _listOfStations;

        public StationList() {
            _listOfStations = new List<Station>();
        }

        public StationList(List<Station> x) {
            _listOfStations = x;
        }

        public void AddStation(string x) {
            _listOfStations.Add(new Station(new DepartureList(), x));
        }

        public List<Station> GetStations() {
            return _listOfStations;
        }

        public Station GetStationByLocation(string location) {
            return _listOfStations.Where(y => y.GetLocation() == location).First();
        }

        public List<Station> LoadStationData() {
            var stations = ReadFromBinaryFile<List<Station>>(@"StationNames.txt");
            return stations;
        }

        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
