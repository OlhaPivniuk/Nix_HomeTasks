using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_6.Extensions
{
    public static class ElectricalApplianceArrayExtension
    {
        public static ElectricalAppliance SearchAppliance(this ElectricalAppliance[] electricalAppliances, int energyCost)
        {
            foreach (ElectricalAppliance elem in electricalAppliances)
            {
                if (elem.EnergyCost == energyCost) return elem;
            }

            throw new ArgumentException("Electrical appliance is not found");
        }

        public static void Sort(this ElectricalAppliance[] electricalAppliances, ComparisonOption option)
        {
            for (int i = electricalAppliances.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (electricalAppliances[j].CompareTo(electricalAppliances[j + 1], option) > 0)
                    {
                        ElectricalAppliance first = electricalAppliances[j];
                        electricalAppliances[j] = electricalAppliances[j + 1];
                        electricalAppliances[j + 1] = first;
                    }
                }
            }
        }
    }
}
