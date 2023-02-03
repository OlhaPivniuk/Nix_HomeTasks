using Module_2.HW_6.Interfaces;
using Module_2.HW_6.Wires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_6.ElectricalAppliances.KitchenAppliances
{
    public class Toaster : KitchenAppliance, IToaster
    {
        public Toaster(string name, int energyCost) : base(name, energyCost)
        {

        }

        public override void ConnectSocket(IWire wire)
        {
            if (wire is ToasterWire)
            {
                IsPowered = true;
                return;
            }

            Console.WriteLine("Wire didn't fit(");
        }

        public void ToastBread()
        {
            if (!IsPowered)
            {
                Console.WriteLine("Toaster not connected");
            }

            Console.WriteLine("Toaster is toasting bread");
        }
    }
}
