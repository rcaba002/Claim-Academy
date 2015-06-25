using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CozaLozaWoza
{
    class Program
    {
        /// <summary>
        /// Prints all numbers from 1 to 110 with 11 numbers per line.
        /// Replaces all multiples of 3, 5, and 7 with 'CozaLozaWoza',
        /// all multiples of 3 and 5 with 'CozaLoza',
        /// all multiples of 3 and 7 with 'CozaWoza',
        /// all multiples of 5 and 7 with 'LozaWoza',
        /// all multiples of just 3 with 'Coza',
        /// all multiples of just 5 with 'Loza',
        /// all multiples of just 7 with 'Woza'
        /// </summary>
        static void Main(string[] args)
        {
            var output = "";

            var count = 1;

            while (count < 111)
            {
                if (count % 3 == 0 && count % 5 == 0 && count % 7 == 0)
                {
                    output += "CozaLozaWoza ";
                }

                else if (count % 3 == 0 && count % 5 == 0)
                {
                    output += "CozaLoza ";
                }
                
                else if (count % 5 == 0 && count % 7 == 0)
                {
                    output += "LozaWoza ";
                }

                else if (count % 3 == 0 && count % 7 == 0)
                {
                    output += "CozaWoza ";
                }

                else
                {
                    if (count % 3 == 0)
                    {
                        output += "Coza ";
                    }
                    
                    else if (count % 5 == 0)
                    {
                        output += "Loza ";
                    }

                    else if (count % 7 == 0)
                    {
                        output += "Woza ";
                    }

                    else
                    {
                        output += count + " ";
                    }
                }

                if (count % 11 == 0)
                {
                    output += "\n";
                }

                count++;
            }

            Console.Write(output);

            Console.ReadKey();
        }
    }
}
