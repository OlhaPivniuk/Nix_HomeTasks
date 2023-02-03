using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_2.Interfaces
{
    public interface IPhoneBook<T> : IEnumerable<T>
        where T : IContact
    {
        IReadOnlyCollection<T> this[string str] { get; }

        void Add(T contact);
    }
}
