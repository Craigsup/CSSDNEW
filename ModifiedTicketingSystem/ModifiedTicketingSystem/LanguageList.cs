using System.Collections.Generic;
using System.Linq;

namespace ModifiedTicketingSystem {
    public class LanguageList {
        private List<Language> ListOfLanguages;

        /// <summary>
        /// Constructor which creates an empty ListOfLanguages
        /// </summary>
        public LanguageList() {
            ListOfLanguages = new List<Language>();
        }

        /// <summary>
        /// Returns language based on the name of the language
        /// </summary>
        /// <param name="name">Name of language to be searched for</param>
        /// <returns>Language found based on the name given</returns>
        public Language GetLanguageByName(string name) {
            return ListOfLanguages.Where(x => x.GetNameOfLang() == name).First();
        }

        /// <summary>
        /// Returns the ListOfLanguages
        /// </summary>
        /// <returns>ListOfLanguages</returns>
        public List<Language> GetAllLanguages() {
            return ListOfLanguages;
        }

        /// <summary>
        /// Adds a given language to the ListOfLanguages
        /// </summary>
        /// <param name="lang">Language to be added to the list</param>
        public void AddLanguage(Language lang) {
            ListOfLanguages.Add(lang);
        }

        /// <summary>
        /// Returns LanguageList as a string for unit test comparison
        /// </summary>
        /// <returns>ListOfLanguages as a string</returns>
        public override string ToString()
        {
            return ListOfLanguages.ToString();
        }
    }
}
