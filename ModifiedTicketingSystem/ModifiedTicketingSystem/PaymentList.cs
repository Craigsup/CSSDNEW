using System;
using System.Collections.Generic;
using System.Linq;

namespace ModifiedTicketingSystem
{
    [Serializable]
    public class PaymentList {
        private List<Payment> _listOfPayments;

        public PaymentList() {
            _listOfPayments = new List<Payment>();
        }

        public void AddPayment(Payment x) {
            _listOfPayments.Add(x);
        }

        public Payment GetPaymentByIndex(int index) {
            return _listOfPayments[index];
        }

        public int GetSize() {
            return _listOfPayments.Count;
        }

        public List<Payment> GetPaymentsByDate(DateTime date) {
            return
                _listOfPayments.Where(
                        x => x.GetDate().Year == date.Year && x.GetDate().Month == date.Month && x.GetDate().Day == date.Day)
                    .ToList();
        }

        public Payment GetPaymentsByDateAndAcc(CustomerAccount x, DateTime y) {
            return null;
        }
    }
}
