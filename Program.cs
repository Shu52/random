using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the Random class, generate a list of 20 random numbers that are in the range of 1-50.
            Random rnd = new Random();

            // // Create a list
            List<int> randomNums = new List<int>();

            // // Populate the list
            for (int i = 0; i < 19; i++)
            {
                randomNums.Add(rnd.Next(1, 51));
                Console.WriteLine($"{randomNums[i]}");
            }
            // Console.WriteLine(randomNums);
            // With the resulting List, populate a new List that contains each number squared. For example, if the original list is 2, 5, 3, 15, the final list will be 4, 25, 9, 225.
            List<int> SqrNums = new List<int>();
            foreach (int number in randomNums)
            {
                SqrNums.Add(number * number);
            }

            SqrNums.RemoveAll(number => number % 2 == 0);
            foreach (int SqrNum in SqrNums)
            {

                Console.WriteLine($"{SqrNum}");
            }

            // Then remove any number that is odd from the list of squared numbers.
        }
    }
}
