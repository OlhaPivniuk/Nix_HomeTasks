using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_2.Interfaces
{
    public interface IContactsService
    {
        void AddContact(string firstName = "", string lastName = "");
    }
}
