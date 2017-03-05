using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqu
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var currentNum = numbers[i];
                var nextNum = numbers[i + 1];
                if (currentNum == nextNum)
                {
                    numbers.RemoveAt(currentNum);
                    numbers.RemoveAt(nextNum);
                    numbers.Add(currentNum + nextNum);
                }
            }
            var result = string.Join(" ", numbers);
            Console.WriteLine(result);
        }
    }
}
