using System.Collections.Generic;

namespace ModifiedTicketingSystem {
    public class Language {
        private readonly string _nameOfLang;
        private readonly List<string> _ticketType;
        private readonly List<string> _route;
        private readonly List<string> _guestOptions;
        private readonly List<string> _loginOptions;
        private readonly List<string> _departure;
        private readonly string _starterOption;
        private readonly List<string> _paymentOptions;
        private readonly List<string> _finalMessage;
        private readonly string _optionText;
        private readonly List<string> _loginText;
        private readonly List<string> _timedPassTitles;

        /// <summary>
        /// Constructor which takes in all of the strings of text which are translated into different languages
        /// </summary>
        /// <param name="nameOfLang"></param>
        /// <param name="ticketType"></param>
        /// <param name="route"></param>
        /// <param name="guestOptions"></param>
        /// <param name="departure"></param>
        /// <param name="starterOption"></param>
        /// <param name="paymentOptions"></param>
        /// <param name="finalMessage"></param>
        /// <param name="optionText"></param>
        /// <param name="loginText"></param>
        /// <param name="loginOptions"></param>
        /// <param name="timedPassTitles"></param>
        public Language(string nameOfLang, List<string> ticketType, List<string> route, List<string> guestOptions, List<string> departure, string starterOption, List<string> paymentOptions, List<string> finalMessage, string optionText, List<string> loginText, List<string> loginOptions, List<string> timedPassTitles ) {
            _nameOfLang = nameOfLang;
            _ticketType = ticketType;
            _route = route;
            _guestOptions = guestOptions;
            _departure = departure;
            _starterOption = starterOption;
            _paymentOptions = paymentOptions;
            _finalMessage = finalMessage;
            _optionText = optionText;
            _loginText = loginText;
            _loginOptions = loginOptions;
            _timedPassTitles = timedPassTitles;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetNameOfLang() {
            return _nameOfLang;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetLogin() {
            return _loginOptions;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetTicketType() {
            return _ticketType ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetRoute() {
            return _route;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetGuestOptions() {
            return _guestOptions;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetDeparture() {
            return _departure;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetStarterOption() {
            return _starterOption;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetPaymentOptions() {
            return _paymentOptions;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetFinalMessage() {
            return _finalMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetOptionText() {
            return _optionText;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetTimedPassTitles() {
            return _timedPassTitles;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return _nameOfLang;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetLoginText() {
            return _loginText;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetLoginOptions() {
            return _loginOptions;
        }
    }
}
