using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedTicketingSystem {
    /// <summary>
    /// Interface for Subject objects
    /// </summary>
    public interface ISubject {
        /// <summary>
        /// Registers an observer to observe this subject
        /// </summary>
        /// <param name="observer"></param>
        void RegisterObserver(IObserver observer);

        /// <summary>
        /// Removes observer from the list of Observers 
        /// </summary>
        /// <param name="observer"></param>
        void UnregisterObserver(IObserver observer);

        /// <summary>
        /// Notifies all observers of changes to the subject
        /// </summary>
        void NotifyObservers();

    }
}
