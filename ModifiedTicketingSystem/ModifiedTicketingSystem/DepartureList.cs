using System;
using System.Collections.Generic;
using System.Linq;

namespace ModifiedTicketingSystem
{
    [Serializable]
    public class DepartureList {
        private List<Departure> _listOfDepartures;

        /// <summary>
        /// a constructor for the departurelist class
        /// </summary>
        public DepartureList() {
            _listOfDepartures = new List<Departure>();
        }

        /// <summary>
        /// a method that adds the x parameter to the list of departures
        /// </summary>
        /// <param name="x"></param>
        public void AddDeparture(Departure x) {
            _listOfDepartures.Add(x);
        }

        /// <summary>
        /// a method that returns the first departure that matches the location and time of the parameters
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>a departure from the list of departures</returns>
        public Departure GetDeparture(Station x, DateTime y) {
            return _listOfDepartures.First(z => z.GetStation().GetLocation() == x.GetLocation() && z.GetDepartureTime() >= y);
        }
    }
}
