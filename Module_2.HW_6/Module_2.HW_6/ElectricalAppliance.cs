using Module_2.HW_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_6
{
    public abstract class ElectricalAppliance
    {
        public bool IsPowered { get; protected set; } = false;

        public int EnergyCost { get; protected set; }

        public string Name { get; }

        public ElectricalAppliance(string name, int energyCost)
        {
            Name = name;

            EnergyCost = energyCost;
        }

        public abstract void ConnectSocket(IWire wire);

        public new string ToString()
        {
            string str = Name + " consumes energy - " + EnergyCost;

            if (IsPowered)
            {
                return str + ", device is connected to the socket";
            }

            return str + ", device is not connected to the socket";

        }
        public int CompareTo(ElectricalAppliance electricalAppliance, ComparisonOption option)
        {
            if (option == ComparisonOption.IsPowered)
            {
                return IsPowered.CompareTo(electricalAppliance.IsPowered);
            }

            if (option == ComparisonOption.Name)
            {
                return Name.CompareTo(electricalAppliance.Name);
            }

            if (option == ComparisonOption.EnergyCost)
            {
                return EnergyCost.CompareTo(electricalAppliance.EnergyCost);
            }
            throw new ArgumentException("Comparison is not implement");
        }
    }
}
