using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelBook.Services
{
    internal class StartService
    {
        public void Start()
        {
            ActionsService<char> actionsServiceChar = new ActionsService<char>();
            ActionsService<int> actionsServiceNum = new ActionsService<int>();
            //ActionsService actionsService = new ActionsService();
            Models.Contact contact = new Models.Contact();
            Models.Aphabeth aphabeth = new Models.Aphabeth();

            List<char> en = new List<char>();
            en = aphabeth.FillAlphabethEN();

            List<int> num = new List<int>();
            num = aphabeth.FillNum();

            List<char> ru = new List<char>();
            ru = aphabeth.FillAlphabethRU();

            Console.WriteLine("Enter language");

            var language = Console.ReadLine();

            CultureInfo culture = new CultureInfo(language);

            if (language == culture.IetfLanguageTag)
            {
                if (culture.TwoLetterISOLanguageName == "en")
                {
                    
                    actionsServiceChar.Compare(contact.Contacts, en);
                    actionsServiceNum.Compare(contact.Contacts, num);
                    actionsServiceChar.Tag(contact.Contacts, ru);
                }
                else if (culture.TwoLetterISOLanguageName == "ru")
                {
                    actionsServiceChar.Compare(contact.Contacts, ru);
                    actionsServiceNum.Compare(contact.Contacts, num);
                    actionsServiceChar.Tag(contact.Contacts, en);
                }
            }
        }
    }
}
