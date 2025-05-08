using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSummary
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var number7 = numbers.Where(d => d == 7).FirstOrDefault();
            Console.WriteLine(number7);

            Console.WriteLine();

            var sortNumbers = numbers.OrderBy(d => d);
            foreach (var num in sortNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            var total = numbers.Sum();
            Console.WriteLine(total);

            var avg = numbers.Average();
            Console.WriteLine(avg);

            var max = numbers.Max();
            Console.WriteLine(max);

            var min = numbers.Min();
            Console.WriteLine(min);

        }
    }
}
