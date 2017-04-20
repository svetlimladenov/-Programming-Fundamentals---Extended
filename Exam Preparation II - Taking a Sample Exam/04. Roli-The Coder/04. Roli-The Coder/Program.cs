using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var currenEventName = new List<string>();
            var result = new SortedDictionary<int, SortedDictionary<string, SortedSet<string>>>();


            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var id = int.Parse(tokens[0]);
                var eventName = tokens[1];
                var participantsOfEvent = tokens.Skip(2).ToArray();

                if (!result.ContainsKey(id))
                {
                    result[id] = new SortedDictionary<string, SortedSet<string>>();
                }


                if (!result[id].ContainsKey(eventName) && eventName[0] == '#')
                {       
                        result[id][eventName] = new SortedSet<string>();
                                 
                }

                for (int i = 0; i < participantsOfEvent.Length; i++)
                {
                    result[id][eventName].Add(participantsOfEvent[i]);

                }


            }  
            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Key);
                foreach (var kur in kvp.Value)
                {
                    Console.WriteLine( kur.Key + " - " + kur.Value.Count);
                    foreach (var asdf in kur.Value)
                    {
                        Console.WriteLine(asdf);
                    }
                }
            }

        }
    }
}
