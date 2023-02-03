using Module_2.HW_4.AnimalType;
using Module_2.HW_4.Interfaces;

namespace Module_2.HW_4
{
    public class Zoo
    {
        public Zoo(ISection section) => Section = section;

        public ISection Section { get; private set; }

        public void ShowDescriptionOfSection()
        {
            Console.WriteLine(Section.GetDescriptionSection());
        }

        public void AddAnimal(Animal animal)
        {
            Section.AddAnimal(animal);
        }
    }
}
