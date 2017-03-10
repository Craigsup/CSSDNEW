using System;
using System.Collections.Generic;
using System.Linq;

namespace ModifiedTicketingSystem {
    [Serializable]
    public class RouteList {
        private List<Route> _listOfRoutes;

        public void AddRoute(Route x) {
            if (_listOfRoutes == null) {
                _listOfRoutes = new List<Route>();
            }

            _listOfRoutes.Add(x);
        }

        public Route GetRouteByStations(Station x, Station y) {
            return _listOfRoutes.FirstOrDefault(z => z.GetStartPoint() == x && z.GetEndPoint() == y);
        }

        public List<Route> GetRoutesFromStation(Station x) {
            List<Route> routes = new List<Route>();
            foreach (var route in _listOfRoutes) {
                if (x == route.GetStartPoint()) {
                    routes.Add(route);
                }
            }
            return routes;
        }

        public List<Route> GetAllRoutes() {
            return _listOfRoutes;
        }
    }
}