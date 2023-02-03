using Module_3.HW_2.Interfaces;
using Module_3.HW_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_2
{
    public class Application
    {
        private readonly IContactsService _contactsService;
        private readonly IPhoneBook<IContact> _phoneBook;
        private readonly string _searchName;

        public Application(IPhoneBook<IContact> phoneBook, IContactsService contactsService)
        {
            _contactsService = contactsService;
            _phoneBook = phoneBook;
            _searchName = "Ped";
        }

        public void Start()
        {
            ProvideContacts();
            DisplayContacts(_searchName);
            Console.ReadKey();
        }

        public void ProvideContacts()
        {            
            _contactsService.AddContact("Василь", "Білецький");
            _contactsService.AddContact("Василіса", "Котенко");
            _contactsService.AddContact("Владислав", "Мартишев");
            _contactsService.AddContact("Ігор", "Лопушко");
            _contactsService.AddContact("Іван", "Фірстов");
            _contactsService.AddContact("Ян", "Кавун");            
            _contactsService.AddContact("Anna", "Klymenko");
            _contactsService.AddContact("Kateryna", "Rydenko");
            _contactsService.AddContact("Olha", "Pivniuk");
            _contactsService.AddContact("Pedro", "Cool");
            _contactsService.AddContact("Pedro", "Smile");     
            _contactsService.AddContact("01234", "56789");
            _contactsService.AddContact("12345", "67890");
            _contactsService.AddContact("98765", "43210");
            _contactsService.AddContact("?Unknown", "Number");
            _contactsService.AddContact("Someone", "&Special");
            _contactsService.AddContact("*#06#*");
            _contactsService.AddContact("!@#%^&*()-_=+");
            _contactsService.AddContact("Olof");
            _contactsService.AddContact("&&&777???Last");           
            _contactsService.AddContact("&999First");
        }

        public void DisplayContacts(string name)
        {
            IReadOnlyCollection<IContact> contacts = _phoneBook[name];
            string newLine = Environment.NewLine;

            Console.WriteLine($"{newLine} Contacts starting with \"{name}\":{newLine}");

            foreach (IContact contact in contacts)
            {
                Console.WriteLine($" {contact.FullName} [{(contact as Contact).Collection}]");
            }
        }
    }
}
