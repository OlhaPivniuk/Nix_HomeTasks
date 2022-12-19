using Module_2.HW_4.AnimalDеscription;
using Module_2.HW_4.AnimalType;

namespace Module_2.HW_4.Extensions
{
    public static class ZooExtension
    {
        public static Animal[] SearchGenderAnimal(this Zoo zoo, SexAnimal sex)
        {
            if (zoo == null)
            {
                return null;
            }

            Animal[] newArray = Array.Empty<Animal>();
            for (int i = 0; i < zoo.Section.Animals.Length; i++)
            {
                if (zoo.Section.Animals[i].Sex == sex)
                {
                    newArray = newArray.Add(zoo.Section.Animals[i]);
                }
            }
            return newArray;
        }
    }
}
