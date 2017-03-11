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

        public void SetRoutes(List<Route> routes) {
            _listOfRoutes = routes;
        }

        public void AddRoute(Route x) {
            if (_listOfRoutes == null) {
                _listOfRoutes = new List<Route>();
            }

            _listOfRoutes.Add(x);
        }

        public Route GetRouteByStations(Station x, Station y) {
            return _listOfRoutes.FirstOrDefault(z => z.GetStartPoint().ToString() == x.ToString() && z.GetEndPoint().ToString() == y.ToString());
        }

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

        public void RegisterObserver(IObserver observer) {
            observers.Add(observer);
        }
        public void UnregisterObserver(IObserver observer) {
            observers.Remove(observer);
        }
        public void NotifyObservers() {
            foreach (IObserver ob in observers) {
                ob.Update(_listOfRoutes);
            }
        }
    }
}