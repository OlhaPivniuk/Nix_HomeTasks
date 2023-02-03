using Module_2.HW_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_6
{
    public interface IElectricalApplianceFactory
    {
        public ElectricalAppliance CreateElectrialAppliance(string name, int energyCost);

        public IWire CreateWire();
    }
}
