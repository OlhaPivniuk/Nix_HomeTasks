using Module_2.HW_4.AnimalDеscription;
using Module_2.HW_4.AnimalType;
using Module_2.HW_4.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_4
{
    public static class Starter
    {
        public static void Run()
        {
            string line = "--------------------------------------------";
            DataFile file = new DataFile();
            Zoo zoo = new Zoo(new Section(file));
            zoo.AddAnimal(new AnimalWithHooves("Antelope", 48f, SexAnimal.Male, "grasses, grass shoots, leaves, tender roots, tubers, shrubs, fruits, mushrooms", "brown", 92f, "even-toed hoofed"));
            Console.WriteLine("An array of animals before sorting by gender: ");
            zoo.ShowDescriptionOfSection();
            Console.WriteLine(line);

            Array.Sort(zoo.Section.Animals);
            Console.WriteLine("An array of animals after sorting by gender: ");
            zoo.ShowDescriptionOfSection();
            Console.WriteLine(line);

            Console.WriteLine("Counting the number of animals in the hierarchy: ");
            var result = zoo.Section.CountAnimalsOfType();
            Console.WriteLine($"Number of animal type: {TypesOfAnimal.Herbivore} - {result.Item1}");
            Console.WriteLine($"Number of animal type: {TypesOfAnimal.AnimalWithWool} - {result.Item2}");
            Console.WriteLine($"Number of animal type: {TypesOfAnimal.AnimalWithHorns} - {result.Item3}");
            Console.WriteLine($"Number of animal type: {TypesOfAnimal.AnimalWithHooves} - {result.Item4}");
            Console.WriteLine(line);

            Random rand = new Random();
            SexAnimal sex = (SexAnimal)rand.Next(2);
            Console.WriteLine($"Search by animal gender: {sex}");
            var result1 = zoo.SearchGenderAnimal(sex);
            if (result1 == null || result1.Length == 0)
            {
                Console.WriteLine("No animals were found matching your request.");
            }
            else
            {
                for (int i = 0; i < result1.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) Name of kind - {result1[i].Kind} | Gender - {result1[i].Sex} | Weight - {result1[i].Weight}");
                }
            }
        }
    }
}
