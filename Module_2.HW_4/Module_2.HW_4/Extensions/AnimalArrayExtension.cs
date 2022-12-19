using Module_2.HW_4.AnimalType;

namespace Module_2.HW_4.Extensions
{
    public static class AnimalArrayExtension
    {
        public static Animal[] Add(this Animal[] arr, Animal animal)
        {
            if (arr == null)
            {
                return null;
            }

            if (animal == null)
            {
                return arr;
            }

            Animal[] newArray = new Animal[arr.Length + 1];
            Array.Copy(arr, newArray, arr.Length);
            newArray[arr.Length] = animal;
            return newArray;
        }
    }
}
