using Microsoft.Extensions.DependencyInjection;
using Module_3.HW_2.Interfaces;
using Module_3.HW_2.Collections;
using Module_3.HW_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3.HW_2
{
    public class Starter
    {
        public void Run()
        {
            ServiceProvider? serviceProvider = new ServiceCollection()
                .AddSingleton<IPhoneBook<IContact>, PhoneBook<IContact>>()
                .AddTransient<IContactsService, ContactsService>()
                .AddTransient<ICultureService, CultureService>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            Application? app = serviceProvider.GetService<Application>();
            app?.Start();
        }
    }
}
