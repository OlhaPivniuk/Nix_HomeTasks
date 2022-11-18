using Module_2.HW_4.AnimalType;

namespace Module_2.HW_4.Interfaces
{
    public interface ISection
    {
        public Animal[] Animals { get; }
        public void AddAnimal(Animal animal);
        public string GetDescriptionSection();
    }
}
