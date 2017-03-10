
using System;

namespace ModifiedTicketingSystem {
    [Serializable]
    public class Payment {
        //private CustomerAccount _account;
        private decimal _amountPaid;
        private decimal _amountOwed;
        private DateTime _dateTime;

        public Payment(decimal amountOwed, decimal amountPaid) {
            _amountOwed = amountOwed;
            _amountPaid = amountPaid;
            _dateTime = DateTime.Now;
        }

        public decimal AddBalance(float x, float y) {
            return 0;
        }

        public decimal SubtractBalance(float x, float y) {
            return 0;
        }

        public void CashPayment(decimal x) {
            _amountOwed -= x;
            _amountPaid += x;
        }

        public void SetAmountPaid(float x) {

        }

        //public void SetAccount(CustomerAccount account) {

        //}

        public decimal GetAmountPaid() {
            return _amountPaid;
        }

        public DateTime GetDate() {
            return _dateTime;
        }

        public decimal GetBalance() {
            return _amountOwed;
        }
    }
}
