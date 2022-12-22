using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_4.TaskLinq
{
    public class Starter
    {
        public void FillData()
        {
            var contact = new List<Contact>()
            {
                new Contact { Name = "Ihor", LastName = "Lopushko", Phone = 380502458643 },
                new Contact { Name = "Oleksii", LastName = "Lymarenko", Phone = 380673574478 },
                new Contact { Name = "Olha", LastName = "Pivniuk", Phone = 380503562577 },
                new Contact { Name = "Denys", LastName = "Shapka", Phone = 380669838844 },
                new Contact { Name = "MIkhailo", LastName = "Kutnii", Phone = 380993563566 },
                new Contact { Name = "Mykyta", LastName = "Petrov", Phone = 80673454444 },
                new Contact { Name = "Oleksandr", LastName = "Yovbak", Phone = 380673454444 },
            };

            var name = contact.Where(w => w.Name.ToUpper().StartsWith('O')).OrderBy(o => o);
            var count = contact.Where(w => w.LastName.ToUpper().StartsWith('P')).Count();
            var skip = contact.Where(w => w.LastName.ToUpper().StartsWith('P')).Skip(2).Take(2);
            var select = contact.Where(m => m.Name.ToUpper().StartsWith("M")).Select(o => new Contact() { Name = "MIkhailo", LastName = "Kutnii", Phone = 380993563566 });
            var lOfDef = contact.Where(w => w.Name.ToUpper().StartsWith("S")).LastOrDefault(o => o.Phone.ToString().StartsWith("7"));
            var distinct = contact.Where(w => w.Name.EndsWith('a')).Distinct(); 
            var instance = contact.Select(s => s.Name.StartsWith('M')).FirstOrDefault();            
        }
    }
}
