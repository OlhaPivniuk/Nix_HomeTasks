using Module_2.HW_4.AnimalDеscription;

namespace Module_2.HW_4.Animals
{
    public class AnimalWithHorns : AnimalWithWool
    {
        public AnimalWithHorns(string kind, float weight, SexAnimal sex, string typeGrassToEat, string colorOfWool, float longOfHorns)
            : base(kind, weight, sex, typeGrassToEat, colorOfWool)
        {
            LongOfHorns = longOfHorns;
        }
        public float LongOfHorns { get; protected set; }

        public override string GetDesription()
        {
            return $"{base.GetDesription()} | Long of horns - {LongOfHorns}";
        }
    }
}
