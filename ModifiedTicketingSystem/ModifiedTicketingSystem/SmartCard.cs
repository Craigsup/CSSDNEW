using System;

namespace ModifiedTicketingSystem {
    public class SmartCard {
        private readonly int _cardId;
        private DateTime _scannedTime;

        /// <summary>
        /// Constructor which takes in a cardId
        /// </summary>
        /// <param name="cardId">cardId for new Smart Card</param>
        public SmartCard(int cardId) {
            _cardId = cardId;
        }

        /// <summary>
        /// Returns cardId
        /// </summary>
        /// <returns>cardId</returns>
        public int GetCardId() {
            return _cardId;
        }

        /// <summary>
        /// Sets the scannedTime to the current time
        /// </summary>
        public void SetScannedTime() {
            _scannedTime = DateTime.Now;
        }

        /// <summary>
        /// Sets the scannedTime to the  given time
        /// </summary>
        /// <param name="x">Time to set the scanned time to</param>
        public void SetScannedTime(DateTime x) {
            _scannedTime = x;
        }

        /// <summary>
        /// Returns the scannedTime
        /// </summary>
        /// <returns>_scannedTime</returns>
        public DateTime GetScannedTime() {
            return _scannedTime;
        }
    }
}
