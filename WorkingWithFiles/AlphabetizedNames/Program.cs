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
        public static List<int> FinalNameScores { get; set; }

        static void Main(string[] args)
        {
            SortNames();
            GetNameScores();
            var total = TotalNameScores(FinalNameScores);

            Console.WriteLine("Total of all name scores: {0:n0}", total);

            Console.ReadKey();
        }

        private static void SortNames()
        {
            var names = GetNames();
            var sortedNames = Alphabetize(names);
            WriteToFile(sortedNames);
        }

        private static List<string> GetNames()
        {
            return File.ReadAllText("../../../resources/names.txt")
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
            File.WriteAllLines("../../../answers/p4aNames.txt", sortedNames);
        }

        private static void GetNameScores()
        {
            var sortedNames = GetSortedNamesFromFile();
            var nameValues = ConvertListOfNamesToNameValues(sortedNames);
            FinalNameScores = MultiplyNameValueByPositionInTheList(nameValues);
            WriteToNewFile(FinalNameScores);
        }

        private static List<string> GetSortedNamesFromFile()
        {
            return File.ReadAllLines("../../../answers/p4aNames.txt").ToList();
        }

        private static List<int> ConvertListOfNamesToNameValues(List<string> sortedNames)
        {
            var sortedNameScore = new List<int>();

            foreach (string name in sortedNames)
            {
                var intSum = name.Sum(letter => letter - 64);

                sortedNameScore.Add(intSum);
            }

            return sortedNameScore;
        }

        private static List<int> MultiplyNameValueByPositionInTheList(List<int> nameValues)
        {
            FinalNameScores = new List<int>();

            for (int i = 0; i < nameValues.Count; i++)
            {
                var nameScore = nameValues[i] * (i + 1);
                FinalNameScores.Add(nameScore);
            }

            return FinalNameScores;
        }

        private static void WriteToNewFile(List<int> finalNameScores)
        {
            var stringList = new List<string>();

            foreach (int item in finalNameScores)
            {
                stringList.Add(item.ToString());
            }

            File.WriteAllLines("../../../answers/p4bNames.txt", stringList);
        }

        private static object TotalNameScores(List<int> finalNameScores)
        {
            return finalNameScores.Sum();
        }
    }
}
