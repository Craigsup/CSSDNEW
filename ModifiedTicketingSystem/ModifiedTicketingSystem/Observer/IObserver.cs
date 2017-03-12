using System.Collections.Generic;

namespace ModifiedTicketingSystem {
    /// <summary>
    /// Interface for Oberver Objects which will observe a subject.
    /// </summary>
    public interface IObserver {
        /// <summary>
        /// Update observers with the amount of tickets that have been bought.
        /// </summary>
        /// <param name="count">The number of tickets that have been bought</param>
        void Update(int count);

        /// <summary>
        /// Update observers with an up-to-date List of Routes.
        /// </summary>
        /// <param name="routes">The Route List</param>
        void Update(List<Route> routes);
    }
}
