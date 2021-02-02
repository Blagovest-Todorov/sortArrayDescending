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

            for (int i = 0; i < numbers.Length; i++)
            {
                // numebrs[i]; -> currentNumb

                for (int j = i+1; j < numbers.Length; j++)  ////5 2 4 10 -> arrange this descending // firsNum must be always maxValue;
                {
                    if (numbers[i] >= numbers[j])
                    {
                        continue;
                    }
                    else // if numbers[i] < numbers[j];
                    {
                        int tempNub = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tempNub;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
