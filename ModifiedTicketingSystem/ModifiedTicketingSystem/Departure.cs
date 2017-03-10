using System;

namespace ModifiedTicketingSystem {
    [Serializable]
    public class Departure {
        private Station _station;
        private DateTime _departureTime;


        /// <summary>
        /// a constructor for the departure class that takes parameters
        /// </summary>
        /// <param name="station"></param>
        /// <param name="departureTime"></param>
        public Departure(Station station, DateTime departureTime) {
            _station = station;
            _departureTime = departureTime;
        }

        /// <summary>
        /// a method that returns 0
        /// </summary>
        /// <returns>0</returns>
        public int GetDepartureID() {
            return 0;
        }

        /// <summary>
        /// a method that returns the departure station
        /// </summary>
        /// <returns>the departure station</returns>
        public Station GetStation() {
            return _station;
        }

        /// <summary>
        /// a method that returns the departure time
        /// </summary>
        /// <returns>the departure time</returns>
        public DateTime GetDepartureTime() {
            return _departureTime;
        }


        /// <summary>
        /// a method that returns true or false based on if the current time is between the peak hours
        /// </summary>
        /// <returns>true or false</returns>
        public bool IsPeakDeparture() {
            return _departureTime.ToLocalTime().Hour > 8 && _departureTime.ToLocalTime().Hour < 19;
        }

        /// <summary>
        /// a method that sets the departure time to the time parameter
        /// </summary>
        /// <param name="time"></param>
        public void SetDepartureTime(DateTime time) {
            _departureTime = time;
        }
    }
}
