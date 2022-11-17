using Module_2.HW_6.ElectricalApplianceFactories;
using Module_2.HW_6.ElectricalAppliances.KitchenAppliances;
using Module_2.HW_6.Extensions;
using Module_2.HW_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "---------------------------------------------";     
            var toasterFactory = new ToasterFactory();
            var dishwasherFactory = new DishwasherFactory();


            var toaster1 = toasterFactory.CreateElectrialAppliance("Gorenje", 100);
            toaster1.ConnectSocket(toasterFactory.CreateWire());

            var toaster2 = toasterFactory.CreateElectrialAppliance("Philips", 120);
            toaster2.ConnectSocket(toasterFactory.CreateWire());

            var toaster3 = toasterFactory.CreateElectrialAppliance("Delonghi", 100);

            var dishwasher1 = dishwasherFactory.CreateElectrialAppliance("BOSCH", 200);

            var dishwasher2 = dishwasherFactory.CreateElectrialAppliance("WHIRLPOOL", 220);

            var dishwasher3 = dishwasherFactory.CreateElectrialAppliance("ELECTROLUX", 180);

            var appliances = new ElectricalAppliance[]
            {
                toaster1,
                toaster2,
                toaster3,
                dishwasher1,
                dishwasher2,
                dishwasher3
            };

            WriteAppliances(appliances);
            Console.WriteLine(line);

            Console.WriteLine("Sorting by energy consumption");

            appliances.Sort(ComparisonOption.EnergyCost);

            WriteAppliances(appliances);
            Console.WriteLine(line);

            Console.WriteLine("Sorting by name");

            appliances.Sort(ComparisonOption.Name);

            WriteAppliances(appliances);
            Console.WriteLine(line);

            Console.WriteLine("Sorting by power connection");

            appliances.Sort(ComparisonOption.IsPowered);

            WriteAppliances(appliances);
            Console.WriteLine(line);

            Console.WriteLine("You are looking for a device with a power consumption of 220V");

            var item = appliances.SearchAppliance(220);
            Console.WriteLine(line);

            Console.WriteLine($"This is {item.ToString()}");
            Console.WriteLine(line);

            Console.WriteLine("General power consumption: " + AllEnergyCost(appliances));

        }
        static void WriteAppliances(ElectricalAppliance[] arr)
        {
            Console.WriteLine();
            Console.WriteLine("Electrical appliances:");
            foreach (var elem in arr)
            {
                Console.WriteLine(elem.ToString());
            }
            Console.WriteLine();
        }
        static int AllEnergyCost(ElectricalAppliance[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item.EnergyCost;
            }

            return sum;
        }
    }
}
