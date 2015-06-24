using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            // change value to any number 0-100 to test method
            byte number = 99;

            var results = WrittenForm(number);

            Console.WriteLine(results);

            Console.ReadKey();
        }

        /// <summary>
        /// A method that takes a number and returns its written form
        /// </summary>
        static string WrittenForm(byte number)
        {
            var words = "";

            // string array of numbers 0-19
            string[] onesUnit = new[] {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
                "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};

            // dictionary of int keys and string values
            Dictionary<byte, string> tensUnit = new Dictionary<byte, string>();

            tensUnit.Add(2, "Twenty");
            tensUnit.Add(3, "Thirty");
            tensUnit.Add(4, "Forty");
            tensUnit.Add(5, "Fifty");
            tensUnit.Add(6, "Sixty");
            tensUnit.Add(7, "Seventy");
            tensUnit.Add(8, "Eighty");
            tensUnit.Add(9, "Ninety");
            
            if (number > 19)
            {
                // switch statement
                switch (number/10)
                {
                    case 2:
                        words = tensUnit[2];
                        break;
                    case 3:
                        words = tensUnit[3];
                        break;
                    case 4:
                        words = tensUnit[4];
                        break;
                    case 5:
                        words = tensUnit[5];
                        break;
                    case 6:
                        words = tensUnit[6];
                        break;
                    case 7:
                        words = tensUnit[7];
                        break;
                    case 8:
                        words = tensUnit[8];
                        break;
                    case 9:
                        words = tensUnit[9];
                        break;
                    default:
                        return number == 100 ? "One Hundred" : "Number must be from 0-100";
                }

                // get digit in ones place
                number %= 10;

                // nested if statement
                if (number > 0)
                {
                    words += "-" + onesUnit[number];
                }
                else
                {
                    return words;
                }
            }
            else
            {
                words = onesUnit[number];
            }

            return words;
        }
    }
}
