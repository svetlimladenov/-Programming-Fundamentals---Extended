using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        public static void Main()
        {
            var collection = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "end")
                {
                    break;
                }

                if (command[0] == "reverse")
                {
                    var reverseFrom = int.Parse(command[2]);
                    var count = int.Parse(command[4]);
                    var result = collection
                        .Skip(reverseFrom)
                        .Take(count)
                        .Reverse()
                        .ToArray();
                    var firstPart = collection.Take(reverseFrom);
                    var secondPart = collection.Reverse().Take(collection.Length - count - reverseFrom).Reverse();
                    Console.WriteLine("["
                        + string.Join(", ", firstPart)
                        + ", "
                        + string.Join(", ", result)
                        + ", "
                        + string.Join(", ", secondPart)
                        + "]");

                }
                else if (command[0] == "sort")
                {
                    var reverseFrom = int.Parse(command[2]);
                    var count = int.Parse(command[4]);
                    var result = collection
                        .Skip(reverseFrom)
                        .Take(count)
                        .OrderBy(a => a)
                        .ToArray();
                    var firstPart = collection.Take(reverseFrom);
                    var secondPart = collection.Reverse().Take(collection.Length - count - reverseFrom).Reverse();
                    if (firstPart.Count() > 0)
                    {
                        Console.WriteLine("["
                            + string.Join(", ", firstPart)
                            + ", "
                            + string.Join(", ", result)
                            + ", "
                            + string.Join(", ", secondPart)
                            + "]");
                    }
                    else
                    {
                        Console.WriteLine("["
                            + string.Join(", ", result)
                            + ", "
                            + string.Join(", ", secondPart)
                            + "]");
                    }
                }
                else if (command[0] == "rollLeft")
                {

                }
                else if (command[0] == "rollRight")
                {

                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
            }

        }
    }
}
