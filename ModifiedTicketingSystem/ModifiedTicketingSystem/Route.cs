using System;
namespace ModifiedTicketingSystem {
    [Serializable]
    public class Route {
        private Station RouteStartPoint;
        private Station RouteEndPoint;
        private decimal Price;

        public Route(Station x, Station y, decimal p) {
            RouteStartPoint = x;
            RouteEndPoint = y;
            Price = p;

        }

        public Station GetStartPoint() {
            return RouteStartPoint;
        }

        public Station GetEndPoint() {
            return RouteEndPoint;
        }

        public decimal GetPrice() {
            return Price;
        }

        public void SetRouteStartPoint(Station station) {
            RouteStartPoint = station;
        }

        public void SetRouteEndPoint(Station station) {
            RouteEndPoint = station;
        }

        public void SetPrice(decimal price) {
            Price = price;
        }
    }
}
