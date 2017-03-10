using System;

namespace ModifiedTicketingSystem
{
    [Serializable]
    public class Journey {
        protected readonly DateTime _routeCompletion;
        protected readonly Route _theRoute;
        //protected readonly CustomerAccount _customer;

        /// <summary>
        /// a constructor for the Journey class
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="theRoute"></param>
        /// <param name="routeCompletion"></param>
        public Journey(Route theRoute, DateTime routeCompletion) {
        //    _customer = customer;
            _theRoute = theRoute;
            _routeCompletion = routeCompletion;
        }

        /// <summary>
        /// a method that returns the route
        /// </summary>
        /// <returns>the route</returns>
        public Route GetRoute() {
            return _theRoute;
        }

        /// <summary>
        /// a method that returns the routes completion time
        /// </summary>
        /// <returns>the routes completion time</returns>
        public DateTime GetCompletionTime() {
            return _routeCompletion;
        }
    }
}
