using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // change values to test methods
            var lowerBound = 1;
            var upperBound = 100;

            // creates an array of numbers within a range
            var numbers = Enumerable.Range(lowerBound, upperBound-(lowerBound-1)).ToArray();

            // uncomment any below to execute

            //numbers = GetOddNumbers(numbers);

            //numbers = GetDivisibleBySeven(numbers);

            //numbers = GetSquares(numbers);

            var sum = GetSum(numbers);

            var average = GetAverage(numbers);

            Console.WriteLine("The sum of the numbers is {0}", sum);
            Console.WriteLine("The average of the numbers is {0}", average);

            Console.ReadKey();
        }

        /// <summary>
        /// Returns sum of all numbers in an array
        /// </summary>
        static int GetSum(int[] numbers)
        {
             return numbers.Sum();
        }

        /// <summary>
        /// Returns average of all numbers in an array
        /// </summary>
        static double GetAverage(int[] numbers)
        {
            return numbers.Average();
        }

        /// <summary>
        /// Returns array of only odd numbers
        /// </summary>
        private static int[] GetOddNumbers(int[] numbers)
        {
            int i = 0;
            var temp = new List<int>();

            while (i < numbers.Count())
            {
                if (numbers[i] % 2 != 0)
                {
                    temp.Add(numbers[i]);
                }

                i++;
            }

            return temp.ToArray();
        }

        /// <summary>
        /// Returns array of only numbers divisible by seven
        /// </summary>
        private static int[] GetDivisibleBySeven(int[] numbers)
        {
            int i = 0;
            var temp = new List<int>();

            while (i < numbers.Count())
            {
                if (numbers[i] % 7 == 0)
                {
                    temp.Add(numbers[i]);
                }

                i++;
            }

            return temp.ToArray();
        }

        /// <summary>
        /// Returns array of squares
        /// </summary>
        private static int[] GetSquares(int[] numbers)
        {
            int i = 0;
            var temp = new List<int>();

            while (i < numbers.Count())
            {
                var square = numbers[i]*numbers[i];
                temp.Add(square);
                i++;
            }

            return temp.ToArray();
        }
    }
}
