using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeNumsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = GetAndSortFile();

            WriteNewFile(numbers);

            var sumOfAll = GetTotal(numbers);

            var firstTenDigits = sumOfAll.ToString(CultureInfo.InvariantCulture).Substring(0, 11);

            Console.WriteLine("{0}", firstTenDigits.Remove(1, 1));

            Console.ReadKey();
        }

        private static string[] GetAndSortFile()
        {
            var lines = File.ReadAllLines("../../../resources/longnums.txt").ToArray();

            Array.Sort(lines);

            return lines;
        }   

        private static void WriteNewFile(string[] numbers)
        {
            File.WriteAllLines("../../../answers/p5a.txt", numbers);
        }

        private static double GetTotal(string[] lines)
        {
            return lines.Sum(line => Convert.ToDouble(line));
        }
    }
}
