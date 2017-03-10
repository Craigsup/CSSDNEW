using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ModifiedTicketingSystem
{
    [Serializable]
    public class JourneyList {
        [DataMember]
        protected List<Journey> _listOfJourneys;

        /// <summary>
        /// a constructor for the journeylist class
        /// </summary>
        public JourneyList() {
            _listOfJourneys = new List<Journey>();
        }

        /// <summary>
        /// a method that adds the x parameter to the list of journeys
        /// </summary>
        /// <param name="x"></param>
        public void AddJourney(Journey x) {
            _listOfJourneys.Add(x);
        }

        /// <summary>
        /// a method that returns a list of journeys
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns>a list of journeys</returns>
        public List<Journey> GetJourneys(Route x, DateTime y, DateTime z) {
            return _listOfJourneys;
        }

        /// <summary>
        /// a method that returns null
        /// </summary>
        /// <param name="x"></param>
        /// <returns>null</returns>
        public List<Journey> GetJourneysForAccount(CustomerAccount x) {
            return null;
        }
    }
}