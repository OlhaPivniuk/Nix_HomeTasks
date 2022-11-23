using Module_3.HW_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_2.Models
{
    public class Contact : IContact
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Collection { get; set; }
        public string FullName
        {
            get
            {
                if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
                {
                    return $"{FirstName} {LastName}";
                }
                else if (!string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName))
                {
                    return $"{FirstName}";
                }
                else if (string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
                {
                    return $"{LastName}";
                }
                else
                {
                    throw new ArgumentNullException("First Name and Last Name are null or empty!");
                }
            }
        }
    }
}
