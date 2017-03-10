namespace ModifiedTicketingSystem {
    public class MobileApp {
        private int _anAccount;
        private Payment _payment;

        /// <summary>
        /// Constructor which takes in an account ot be set
        /// </summary>
        /// <param name="anAccount">Account which is logged in</param>
        public MobileApp(int anAccount) {
            _anAccount = anAccount;
        }

        /// <summary>
        /// Top-up the balance of the account which is logged in
        /// </summary>
        /// <param name="x">Amount of money to be added to the balance</param>
        /// <returns>True when the balance has been added</returns>
        public bool MakePayment(decimal x) {
            new CustomerAccount().TopUpBalance(_anAccount, x);
            return true;
        }
    }
}