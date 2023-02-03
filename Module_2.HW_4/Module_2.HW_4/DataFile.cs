using Module_2.HW_4.AnimalDеscription;
using Module_2.HW_4.Animals;
using Module_2.HW_4.AnimalType;
using Module_2.HW_4.Interfaces;

namespace Module_2.HW_4
{
    public class DataFile : IDataProvider
    {
        public Animal[] GetData()
        {
            return new Animal[]
            {
            new AnimalWithHooves("Zebra", 450, SexAnimal.Male, "grass", "black and white", 0f, "odd-toed hoofed"),
            new AnimalWithHooves("Giraffe", 1200f, SexAnimal.Female, "leaves and buds on trees and shrubs", "orange brown", 200f, "even-toed hoofed"),
            new AnimalWithHorns("Rhino", 123f, SexAnimal.Male, "low-energy grasses", "grey", 150f),
            new AnimalWithHorns("Gazelle", 55f, SexAnimal.Female, "grass, leaves, plants", "brown", 12f),
            new AnimalWithWool("Lama", 134f, SexAnimal.Female, "grasses, flowering plants", "white"),
            new AnimalWithWool("Camel", 700f, SexAnimal.Male, "shrubs, trees, grass, leaves", "brown"),
            new Herbivore("Hippopotamus", 1700f, SexAnimal.Male, "grass, leaves, fruit and aquatic plants"),
            new Herbivore("Elephant", 3500f, SexAnimal.Female, "grasses and leafy material from shrubs and trees")
            };
        }
    }
}
