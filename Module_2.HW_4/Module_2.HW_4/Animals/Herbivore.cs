using Module_2.HW_4.AnimalDеscription;
using Module_2.HW_4.AnimalType;

namespace Module_2.HW_4.Animals
{
    public class Herbivore : Animal
    {
        public Herbivore(string kind, float weight, SexAnimal sex, string typeGrassToEat)
            : base(kind, weight, sex)
        {
            TypeGrassToEat = typeGrassToEat;
        }

        public string TypeGrassToEat { get; }

        public override string GetDesription()
        {
            return $"{base.GetDesription()} | Food - {TypeGrassToEat}";
        }
    }
}
