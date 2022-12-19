using Module_2.HW_4.AnimalDеscription;

namespace Module_2.HW_4.AnimalType
{
    public abstract class Animal : IComparable<Animal>
    {
        public Animal(string kind, float weight, SexAnimal sex)
        {
            Kind = kind;
            Weight = weight;
            Sex = sex;
        }
        public string Kind { get; }
        public SexAnimal Sex { get; }
        public float Weight { get; protected set; }

        public virtual string GetDesription()
        {
            return $"Kind - {Kind} | Sex - {Sex} | Weight - {Weight}";
        }

        public int CompareTo(Animal? other)
        {
            return Sex.CompareTo(other.Sex);
        }
    }
}
