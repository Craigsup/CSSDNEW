using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModifiedTicketingSystem;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TicketingSystemTest {
    [TestClass]
    public class SamUnitTest {

        class MockObserver : IObserver{
            private int _count;
            List<Route> _routes;

            public MockObserver() {
                _count = 0;
                _routes = new List<Route>();
            }

            public void Update(int count){
                _count = count; 
            }

            public int GetCount() {
                return _count;
            }

            public void Update(List<Route> routes){
                _routes = routes;
            }

            public List<Route> GetRoutes() {
                return _routes;
            }
        }

        [TestMethod]
        public void TestCounterSubject() {
            Counter counter = new Counter();
            MockObserver observer1 = new MockObserver();
            MockObserver observer2 = new MockObserver();

            counter.RegisterObserver(observer1);
            counter.RegisterObserver(observer2);

            counter.Increment();

            Assert.IsTrue(observer1.GetCount() == 1);
            Assert.IsTrue(observer2.GetCount() == 1);

            counter.UnregisterObserver(observer1);
            counter.Increment();

            Assert.IsTrue(observer1.GetCount() == 1);
            Assert.IsTrue(observer2.GetCount() == 2);
        }

        [TestMethod]
        public void TestRouteListSubject() {
            RouteList routes = new RouteList();
            MockObserver observer1 = new MockObserver();
            MockObserver observer2 = new MockObserver();

            WriteToBinaryFile<List<Ticket>>(@"Berlin_tickets.txt", new List<Ticket>(), false);
            WriteToBinaryFile<List<Ticket>>(@"Paris_tickets.txt", new List<Ticket>(), false);

            Station Berlin = new Station("Berlin");
            Station Paris = new Station("Paris");
            Route BerlinParis = new Route(Berlin, Paris, 1234.00m);

            routes.RegisterObserver(observer1);
            routes.RegisterObserver(observer2);

            routes.AddRoute(BerlinParis);

            Assert.IsTrue(observer1.GetRoutes() == routes.GetAllRoutes());
            Assert.IsTrue(observer2.GetRoutes() == routes.GetAllRoutes());

            File.Delete(@"Berlin_tickets.txt");
        }

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false) {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create)) {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }
    }
}
