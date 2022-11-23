using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_2.Interfaces
{
    public interface IContact
    {
        string FirstName { get; init; }
        string FullName { get; }
        string LastName { get; init; }
    }
}
