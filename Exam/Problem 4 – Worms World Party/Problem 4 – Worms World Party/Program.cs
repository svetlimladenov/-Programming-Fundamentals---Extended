using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Worms_World_Party
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "quit")
                {
                    break;
                }
                var inputParams = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine();    
            }
            Console.WriteLine();
        }
    }
}
