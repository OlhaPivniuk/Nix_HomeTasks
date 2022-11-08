using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_2
{
    public class User
    {        
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public User(string name, string lastName)
        {
            Name = name;
            LastName = lastName;      
        }
    }
}
