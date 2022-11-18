using Module_2.HW_4.AnimalDеscription;
using Module_2.HW_4.Interfaces;

namespace Module_2.HW_4.Extensions
{
    public static class ISectionArrayExtension
    {
        public static (int, int, int, int) CountAnimalsOfType(this ISection section)
        {
            if (section == null)
            {
                return (0, 0, 0, 0);
            }

            (int AnimalWithWool, int AnimalWithHorns, int AnimalWithHooves, int Herbivore) countEveryoneTypes = (0, 0, 0, 0);
            for (int i = 0; i < section.Animals.Length; i++)
            {
                if (section.Animals[i].GetType().Name == TypesOfAnimal.Herbivore.ToString())
                {
                    countEveryoneTypes.Herbivore++;
                }
                else if (section.Animals[i].GetType().Name == TypesOfAnimal.AnimalWithHooves.ToString())
                {
                    countEveryoneTypes.AnimalWithHooves++;
                }
                else if (section.Animals[i].GetType().Name == TypesOfAnimal.AnimalWithHorns.ToString())
                {
                    countEveryoneTypes.AnimalWithHorns++;
                }
                else
                {
                    countEveryoneTypes.AnimalWithWool++;
                }
            }

            return countEveryoneTypes;
        }
    }
}
