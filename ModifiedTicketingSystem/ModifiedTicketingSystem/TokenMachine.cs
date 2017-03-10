using System;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    public class TokenMachine {
        private int _anAccount;
        private CardReader _reader;
        private Ticket _ticket;
        private SmartCard _card;
        private DateTime _dateTimePrint;
        private PaymentList _paymentList;
        private decimal _dayPassPrice;

        public TokenMachine(decimal dayPassPrice) {
            _dayPassPrice = dayPassPrice;
            _paymentList = new PaymentList();
            _ticket = null;
            _card = null;
            _reader = null;
            _anAccount = 0;
            
        }

        public void PrintTicket() {

        }

        public Ticket DispenseTicket() {
            return null;
        }

        public void PrintCard() {

        }

        public SmartCard DispenseCard() {
            return null;
        }

        public decimal NumberOfDaysPrice(int days) {
            return GetDayPassPrice() * days;
        }

        public decimal GetDayPassPrice() {
            return _dayPassPrice;
        }

        public PaymentList MakeCashPayment(decimal due, decimal given, Label _due) {
            //_paymentList.AddPayment(new Payment(due, given));
            Payment lastPayment;

            if (_paymentList.GetSize() == 0) {
                _paymentList.AddPayment(new Payment(due, 0));
                _paymentList.AddPayment(new Payment(_paymentList.GetPaymentByIndex(_paymentList.GetSize() - 1).GetBalance()-given, given));
                _due.Text = "£" + _paymentList.GetPaymentByIndex(_paymentList.GetSize() - 1).GetBalance();
                lastPayment = _paymentList.GetPaymentByIndex(_paymentList.GetSize() - 1);
                if (lastPayment.GetBalance() <= 0) {
                    new CustomerAccount(_anAccount).AddTransaction(_paymentList);
                }
                return lastPayment.GetBalance() > 0 ? null : _paymentList;
            }

            lastPayment = _paymentList.GetPaymentByIndex(_paymentList.GetSize() - 1);
            if (lastPayment.GetBalance() > 0) {
                _paymentList.AddPayment(new Payment(lastPayment.GetBalance()-given, given));
                lastPayment = _paymentList.GetPaymentByIndex(_paymentList.GetSize() - 1);
                _due.Text = "£" + lastPayment.GetBalance();

                //lastPayment = _paymentList.GetPaymentByIndex(_paymentList.GetSize() - 1);
                if (lastPayment.GetBalance() <= 0) {
                    new CustomerAccount(_anAccount).AddTransaction(_paymentList);
                }
                return lastPayment.GetBalance() > 0 ? null : _paymentList;
            }

            //_anAccount.AddTransaction();
            return _paymentList;
        }

        public decimal GetPaidAmount() {
            var size = _paymentList.GetSize() - 1;
            return size >= 0 ?_paymentList.GetPaymentByIndex(size).GetBalance() : 0;
        }

        public void MakeCardPayment(decimal due, decimal given) {
            _paymentList.AddPayment(new Payment(due, given));
            new CustomerAccount(_anAccount).AddTransaction(_paymentList);
        }

        internal void MakeBalancePayment(decimal due, decimal given) {
            _paymentList.AddPayment(new Payment(due, given));
            new CustomerAccount(_anAccount).AddTransaction(_paymentList);
            new CustomerAccount(_anAccount).UpdateBalance(-given);
        }

        public void SetAccount(int id) {
            _anAccount = id;
        }


        public void Reset() {
            _paymentList = null;
        }

    }
}
