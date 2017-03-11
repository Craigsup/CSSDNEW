using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModifiedTicketingSystem;

namespace TicketingSystemTest
{
    [TestClass]
    public class TomUnitTest
    {
        [TestMethod]
        [DeploymentItem(@"Languages\"+"1english.language")]
        public void LoadLanguageTest()
        {
            string path = Environment.CurrentDirectory;

            string[] files = Directory.GetFiles(path, "*.language");

            TokenMachine testMachine = new TokenMachine(0.0m);

            Language english = new Language("English",
                new List<string> { "Single Journey", "Timed Pass" },
                new List<string>(),
                new List<string> { "Continue as guest", "Continue to account" },
                new List<string>(),
                "Select a Language",
                new List<string> { "Select payment option", "Pay by card", "Pay by cash", "Pay using balance" },
                new List<string> { "Printing tickets" },
                "Choose an option",
                new List<string> { "Enter login details", "Username", "Password" },
                new List<string> { "Top-up balance", "Print temporary pass", "Single Journey" },
                new List<string> { "Pass Days", "Quantity" });

            LanguageList englishLangList = new LanguageList();
            englishLangList.AddLanguage(english);

            LanguageList newLanguageList = testMachine.LoadLanguages(files);

            for (int i = 0; i < 20; i++)
            {
                Assert.AreEqual(newLanguageList.ToString(), englishLangList.ToString());
            }
        }
    }
}
