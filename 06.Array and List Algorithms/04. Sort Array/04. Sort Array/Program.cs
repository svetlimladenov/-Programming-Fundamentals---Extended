using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    var currentNum = numbers[i];
                    var nextNum = numbers[i + 1];
                    if (nextNum < currentNum)
                    {
                        numbers[i + 1] = currentNum;
                        numbers[i] = nextNum;
                        swapped = true;
                    }
                }
            } while (swapped);
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
