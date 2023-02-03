using System;
using System.Globalization;

namespace Array
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of array elements:");
            int numberOfArrayElements = int.Parse(Console.ReadLine() ?? "0");
            Random rand = new Random();

            int[] myIntArray = new int[numberOfArrayElements];

            for (int i = 0; i < numberOfArrayElements; i++)
            {
                myIntArray[i] = rand.Next(1, 26);
            }

            var str = string.Join(" ", myIntArray);
            Console.WriteLine(str);
            int[] evenArray = new int[myIntArray.Length];
            int[] oddArray = new int[myIntArray.Length];
            int j = 0, k = 0;
            for (int i = 0; i < numberOfArrayElements; i++)
            {
                if (myIntArray[i] % 2 == 0)
                {
                    evenArray[j] = myIntArray[i];
                    j++;
                }
                else
                {
                    oddArray[k] = myIntArray[i];
                    k++;
                }
            }

            Console.Write("\nThe Even elements are : \n");
            for (int i = 0; i < j; i++)
            {
                Console.Write("{0} ", evenArray[i]);
            }

            Console.Write("\nThe Odd elements are :\n");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", oddArray[i]);
            }

            Console.Write("\n\n");
            var alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var alphabetFromEvenArray = new char[evenArray.Length];
            var alphabetFromOddArray = new char[oddArray.Length];

            for (int i = 0; i < evenArray.Length; i++)
            {
                if (evenArray[i] > 0)
                {
                    alphabetFromEvenArray[i] = alphabet[evenArray[i] - 1];
                }
            }

            for (int i = 0; i < oddArray.Length; i++)
            {
                if (oddArray[i] > 0)
                {
                    alphabetFromOddArray[i] = alphabet[oddArray[i] - 1];
                }
            }

            int countAlphabetFromEvenArray = 0;
            for (int i = 0; i < alphabetFromEvenArray.Length; i++)
            {
                if (alphabetFromEvenArray[i] == 'a' || alphabetFromEvenArray[i] == 'e' || alphabetFromEvenArray[i] == 'i' || alphabetFromEvenArray[i] == 'd' || alphabetFromEvenArray[i] == 'h' || alphabetFromEvenArray[i] == 'j')
                {
                    alphabetFromEvenArray[i] = char.ToUpper(alphabetFromEvenArray[i]);
                    countAlphabetFromEvenArray++;
                }
            }

            int countAlphabetFromOddArray = 0;
            for (int i = 0; i < alphabetFromOddArray.Length; i++)
            {
                if (alphabetFromOddArray[i] == 'a' || alphabetFromOddArray[i] == 'e' || alphabetFromOddArray[i] == 'i' || alphabetFromOddArray[i] == 'd' || alphabetFromOddArray[i] == 'h' || alphabetFromOddArray[i] == 'j')
                {
                    alphabetFromOddArray[i] = char.ToUpper(alphabetFromOddArray[i]);
                    countAlphabetFromOddArray++;
                }
            }

            if (countAlphabetFromEvenArray > countAlphabetFromOddArray)
            {
                Console.WriteLine("First array has more uppercase letters");
            }

            if (countAlphabetFromOddArray > countAlphabetFromEvenArray)
            {
                Console.WriteLine("Second array has more uppercase letters");
            }

            if (countAlphabetFromEvenArray == countAlphabetFromOddArray)
            {
                Console.WriteLine("Both arrays have the same upper case letters");
            }

            Console.WriteLine(string.Join(" ", alphabetFromEvenArray));
            Console.WriteLine(string.Join(" ", alphabetFromOddArray));
        }
    }
}
