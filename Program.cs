using System;
using System.Linq;

namespace ArangeArrayDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()  //We created the array and read some input info from the console
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers); // sorting an array form lowest value to the maxValue
            Array.Reverse(numbers);  //sorting the array from MaxValue to LowestValue

            Console.WriteLine();
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
