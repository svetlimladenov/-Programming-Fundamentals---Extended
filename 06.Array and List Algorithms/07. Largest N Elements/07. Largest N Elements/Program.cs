using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var totalNumbers = int.Parse(Console.ReadLine());
            numbers.Sort();
            numbers.Reverse();
            //var result = new List<int>();
            //for (int i = 0; i < totalNumbers; i++)
            //{
            //    result.Add(numbers[i]);
            //}
            var result = numbers.Take(totalNumbers);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
