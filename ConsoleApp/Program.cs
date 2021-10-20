using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1\n");

            int number = 323455;
            var reversedNumber = number.ToString().Reverse().Select(o => Convert.ToInt32(o) - 48).ToArray();
            foreach (var item in reversedNumber)
            {
                Console.Write(item);
            }

            Console.WriteLine("\n\nTask 2\n");

            int[] arrayOfNumbers = new int[] { 1, 2, 3, 4, -5, -7, -4};
            var newArrayOfNumber1 = arrayOfNumbers.Count(i => i > 0);
            var newArrayOfNumber2 = arrayOfNumbers.Where(i => i < 0).Sum();
            var newArrayOfNumber3 = new int[] { newArrayOfNumber1, newArrayOfNumber2};

            foreach (var o in newArrayOfNumber3)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("\n\nTask 3\n");

            var arrayOfStrings = new string[] { "Testtesttest", "Test", "Testtest"};
            var sortedArrayOfStrings = arrayOfStrings.OrderBy(o => o.Length);
            foreach (var o in sortedArrayOfStrings)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("\n\nTask 4\n");

            var uniqueIntArray = new int[] {2, 2, 2, 4, 2, 2, 2 };
            var uniqueIntArray2 = uniqueIntArray.GroupBy((item1) => item1).Where((item2) => item2.Count() == 1).FirstOrDefault();
            foreach (var item in uniqueIntArray2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
