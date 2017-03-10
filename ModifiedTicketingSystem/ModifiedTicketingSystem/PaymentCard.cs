using System;
using System.Runtime.Serialization;

namespace ModifiedTicketingSystem
{
    [Serializable]
    public class PaymentCard
    {
        [DataMember]
        private string _cardNumber;
        [DataMember]
        private DateTime _expiryDate;
        [DataMember]
        private DateTime? _startDate;
        [DataMember]
        private string _cardHolderName;

        /// <summary>
        /// Constructor which takes in all the attributes of a PaymentCard
        /// </summary>
        /// <param name="cardnumber">The Card Number</param>
        /// <param name="expiryDate">Expiry date on the card</param>
        /// <param name="cardHolderName">Name of the card holder</param>
        public PaymentCard (string cardnumber, DateTime expiryDate, string cardHolderName) {
            _cardNumber = cardnumber;
            _expiryDate = expiryDate;
            _cardHolderName = cardHolderName;
        }

        /// <summary>
        /// Returns the last 4 digits of the card number
        /// </summary>
        /// <returns>string of 12 * and the last 4 digits</returns>
        public string GetLastFourDigits() {
            return "**** **** **** "+_cardNumber.Substring(_cardNumber.Length-4);
        }
    }
}
