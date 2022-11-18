using Module_2.HW_4.AnimalDеscription;

namespace Module_2.HW_4.Animals
{
    public class AnimalWithWool : Herbivore
    {
        public AnimalWithWool(string kind, float weight, SexAnimal sex, string typeGrassToEat, string colorOfWool)
            : base(kind, weight, sex, typeGrassToEat)
        {
            ColorOfWool = colorOfWool;
        }

        public string ColorOfWool { get; }

        public override string GetDesription()
        {
            return $"{base.GetDesription()} | Color of wool - {ColorOfWool}";
        }
    }
}
