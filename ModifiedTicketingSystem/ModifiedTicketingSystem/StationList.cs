using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedTicketingSystem {
    [Serializable]
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
    }
}
