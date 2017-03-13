using System;
using System.Collections.Generic;
using System.IO;
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
        /// <summary>
        /// Loads all the .language files in the "files" array and creates a LanguageList from them
        /// </summary>
        /// <param name="files">Array of locations of .language files</param>
        /// <returns>LanguageList created from all .language files</returns>
        public LanguageList LoadLanguages(string[] files)
        {
            //Creates LanguageList to temporarily hold languages
            LanguageList langListTemp = new LanguageList();

            //goes through each language file and creates a Language object for it
            for (int i = 0; i < files.Length; i++)
            {
                var languageTemp = File.ReadAllLines(files[i]);

                langListTemp.AddLanguage(new Language(languageTemp[0],
                new List<string> { languageTemp[1], languageTemp[2] },
                new List<string>(),
                new List<string> { languageTemp[3], languageTemp[4] },
                new List<string>(),
                languageTemp[5],
                new List<string> { languageTemp[6], languageTemp[7], languageTemp[8], languageTemp[9] },
                new List<string> { languageTemp[10] },
                languageTemp[11],
                new List<string> { languageTemp[12], languageTemp[13], languageTemp[14] },
                new List<string> { languageTemp[15], languageTemp[16], languageTemp[17] },
                new List<string> { languageTemp[18], languageTemp[19] }));
            }

            //return langListTemp to GUI
            return langListTemp;
        }

    }
}
