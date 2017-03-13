using System;
using System.Collections.Generic;
using System.Linq;

namespace ModifiedTicketingSystem {
    [Serializable]
    public class RouteList : ISubject {
        private List<IObserver> observers;
        private List<Route> _listOfRoutes;

        public RouteList() {
            observers = new List<IObserver>();
            _listOfRoutes = new List<Route>();
        }

        /// <summary>
        /// Allows the whole List<Route> to be overwritten. This is used when the routelist is being updated
        /// from the subject as it allows the whole list to be updated with all the changes regardless of
        /// whether routes have been added or removed without passing extra variables through.
        /// </summary>
        /// <param name="routes"></param>
        public void SetRoutes(List<Route> routes) {
            _listOfRoutes = routes;
        }

        /// <summary>
        /// A route is passed through and is added to the route list. The list is initialized if it hasn't been
        /// already. Once the route has been added, all of the observers are then notified of the change.
        /// </summary>
        /// <param name="x"></param>
        public void AddRoute(Route x) {
            if (_listOfRoutes == null) {
                _listOfRoutes = new List<Route>();
            }

            _listOfRoutes.Add(x);
            NotifyObservers();
        }

        /// <summary>
        /// If the list of routes exists and contains at least one item then route 'x' is removed from the list.
        /// </summary>
        /// <param name="x"></param>
        public void DeleteRoute(Route x) {
            if ((_listOfRoutes != null) && (_listOfRoutes.Count > 0)) {
                _listOfRoutes.Remove(x);
                NotifyObservers();
            }
        }

        /// <summary>
        /// Finds the first route in the list which starts with station 'x' and ends with station 'y'. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Route GetRouteByStations(Station x, Station y) {
            return _listOfRoutes.FirstOrDefault(z => z.GetStartPoint().ToString() == x.ToString() && z.GetEndPoint().ToString() == y.ToString());
        }

        /// <summary>
        /// Cycles through all the routes and finds all routes with the start station 'x'.
        /// A list of all the routes starting with that station is then returned.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public List<Route> GetRoutesFromStation(Station x) {
            List<Route> routes = new List<Route>();
            foreach (var route in _listOfRoutes) {
                if (x.ToString() == route.GetStartPoint().ToString()) {
                    routes.Add(route);
                }
            }
            return routes;
        }


        public List<Route> GetAllRoutes() {
            return _listOfRoutes;
        }

        /// <summary>
        /// Adds an observer to the RouteList's list of observers
        /// </summary>
        /// <param name="observer"></param>
        public void RegisterObserver(IObserver observer) {
            observers.Add(observer);
        }

        /// <summary>
        /// Removes an observer from the RouteList's list of observers
        /// </summary>
        /// <param name="observer"></param>
        public void UnregisterObserver(IObserver observer) {
            observers.Remove(observer);
        }

        /// <summary>
        /// Notifies every observer in the list of observers of a change to the RouteList
        /// </summary>
        public void NotifyObservers() {
            foreach (IObserver ob in observers) {
                ob.Update(_listOfRoutes);
            }
        }
    }
}