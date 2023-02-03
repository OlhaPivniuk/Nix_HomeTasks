using Module_2.HW_6.Interfaces;
using Module_2.HW_6.Wires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_6.ElectricalAppliances.KitchenAppliances
{
    internal class Dishwasher: KitchenAppliance
    {
        public Dishwasher(string name, int energyCost) : base(name, energyCost)
        {

        }

        public override void ConnectSocket(IWire wire)
        {
            if (wire is DishwasherWire)
            {
                IsPowered = true;
                return;
            }

            Console.WriteLine("Wire didn't fit(");
        }
    }
}
