using System.Collections.Generic;

namespace ModifiedTicketingSystem {
    public class Counter : ISubject {
        private List<IObserver> observers;
        private int count;

        public Counter() {
            observers = new List<IObserver>();
            count = 0;
        }

        /// <summary>
        /// Increase the amount of tickets bought by one
        /// </summary>
        public void Increment() {
            count++;
            NotifyObservers();
        }

        /// <summary>
        /// Register a new observer to the number of tickets bought
        /// </summary>
        /// <param name="observer"></param>
        public void RegisterObserver(IObserver observer) {
            observers.Add(observer);
        }

        /// <summary>
        /// remove an observer
        /// </summary>
        /// <param name="observer"></param>
        public void UnregisterObserver(IObserver observer) {
            observers.Remove(observer);
        }

        /// <summary>
        /// Update all observers with the new ticket count
        /// </summary>
        public void NotifyObservers() {
            foreach (IObserver ob in observers) {
                ob.Update(count);
            }
        }
    }
}
