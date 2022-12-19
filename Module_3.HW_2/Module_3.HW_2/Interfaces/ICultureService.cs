using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_2.Interfaces
{
    public interface ICultureService
    {
        void Add(params string[] cultureIDs);
        CultureInfo[] GetCultureData();
        object GetCulture(string str);
    }
}
