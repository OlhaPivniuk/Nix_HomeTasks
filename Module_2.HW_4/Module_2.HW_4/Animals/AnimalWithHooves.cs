using Module_2.HW_4.AnimalDеscription;
using Module_2.HW_4.Animals;

namespace Module_2.HW_4.AnimalType
{
    public class AnimalWithHooves : AnimalWithHorns
    {
        public AnimalWithHooves(string kind, float weight, SexAnimal sex, string typeGrassToEat, string colorOfWool, float longOfHorns, string typeOfHooves)
            : base(kind, weight, sex, typeGrassToEat, colorOfWool, longOfHorns)
        {
            TypeOfHooves = typeOfHooves;
        }

        public string TypeOfHooves { get; }

        public override string GetDesription()
        {
            return $"{base.GetDesription()} | Type of hooves - {TypeOfHooves}";
        }
    }
}
