using Module_3.HW_2.Interfaces;
using Module_3.HW_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_2.Services
{
    public class ContactsService : IContactsService
    {
        private readonly IPhoneBook<IContact> _phoneBook;

        public ContactsService(IPhoneBook<IContact> phoneBook)
        {
            _phoneBook = phoneBook;
        }

        public void AddContact(string firstName = "", string lastName = "")
        {
            Contact contact = new Contact { FirstName = firstName, LastName = lastName };
            _phoneBook.Add(contact);
        }
    }
}
