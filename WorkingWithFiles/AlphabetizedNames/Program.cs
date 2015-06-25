using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetizedNames
{
    class Program
    {
        static void Main(string[] args)
        {
            SortNames();
        }

        private static void SortNames()
        {
            var names = GetNames();
            var sortedNames = Alphabetize(names);
            WriteToFile(sortedNames);
        }

        private static List<string> GetNames()
        {
            return File.ReadAllText("../resources/names.txt")
                .Replace("\"", string.Empty)
                .Split(',')
                .ToList();
        }

        private static List<string> Alphabetize(List<string> names)
        {
            return names.OrderBy(name => name).ToList();
        }

        private static void WriteToFile(List<string> sortedNames)
        {
            File.WriteAllLines("p4aNames.txt", sortedNames);
        }
    }
}
