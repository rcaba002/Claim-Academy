using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassFail
{
    class Program
    {
        static void Main(string[] args)
        {
            // an integer value labelled 'mark' that is defined as zero
            int mark = 0;

            // begin if/else statement
            if (mark >= 50)
            {
                // display a string to the console
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

            // rewritten using conditional operator (?:)
            // Console.WriteLine(mark >= 50 ? "PASS" : "FAIL");
        }
    }
}
