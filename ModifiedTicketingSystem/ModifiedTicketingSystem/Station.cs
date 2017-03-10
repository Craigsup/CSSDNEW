using System;

namespace ModifiedTicketingSystem {
    [Serializable]
    public class Station {
        protected DepartureList _departureList;
        protected string _location { get; set; }

        public Station(DepartureList departureList, string location) {
            _departureList = departureList;
            _location = location;
        }

        public Station(string Location) {
            _location = Location;
        }

        public DepartureList GetDepartures() {
            return _departureList;
        }

        public string GetLocation() {
            return _location;
        }

        public override string ToString() {
            return _location;
        }
    }
}
