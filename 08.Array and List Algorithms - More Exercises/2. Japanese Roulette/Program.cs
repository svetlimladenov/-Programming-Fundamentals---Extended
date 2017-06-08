
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RussianRoulet
{
    class Program
    {
        static void Main(string[] args)
        {
            var cylinder = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var playersInput = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            bool alive = true;
            int currentIndex = 0;
            int player = 0;
            while (alive)
            {
                var commandParams = playersInput[player].Split(',');
                var power = int.Parse(commandParams[0]);
                var direction = commandParams[1];
                var counter = 0;
                switch (direction)
                {
                    case "Right":
                        currentIndex = (currentIndex + power) % 6;
                        if (cylinder[currentIndex] == 1)
                        {
                            Console.WriteLine("Game over! Player {0} is dead.", player);
                            return;
                        }
                        else
                        {
                            alive = true;
                        }
                        break;
                    case "Left":
                        currentIndex = Math.Abs(currentIndex - power) % 6;
                        if (cylinder[currentIndex] == 1)
                        {
                            Console.WriteLine("Game over! Player {0} is dead.", player);
                            return;
                        }
                        else
                        {
                            alive = true;
                        }
                        break;
                   
                }

                for (int i = 0; i < cylinder.Length; i++)
                {
                    if (i == cylinder.Length - 1)
                    {
                        cylinder[cylinder.Length - 1] = 0;
                        cylinder[0] = 0;
                        break;
                    }
                    if (cylinder[i] == 1)
                    {
                        cylinder[i] = 0;
                        cylinder[i + 1] = 1;
                        break;
                    }
                }
                player++;

                counter++;

                if (counter > playersInput.Length)
                {
                    Console.WriteLine("Everybody got lucky!");
                    return;
                }
            }


            
            
        }
    }
}