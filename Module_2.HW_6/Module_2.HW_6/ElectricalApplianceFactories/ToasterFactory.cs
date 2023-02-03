using Module_2.HW_6.ElectricalAppliances.KitchenAppliances;
using Module_2.HW_6.Interfaces;
using Module_2.HW_6.Wires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_6.ElectricalApplianceFactories
{
    public class ToasterFactory : IElectricalApplianceFactory
    {
        public ElectricalAppliance CreateElectrialAppliance(string name, int energyCost)
        {
            return new Toaster(name, energyCost);
        }

        public IWire CreateWire()
        {
            return new ToasterWire();
        }
    }
}
