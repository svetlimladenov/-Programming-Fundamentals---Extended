using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.NSA
{
    class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "quit")
                {
                    break;
                }

                var commandParams = command.Split(new[] {" -> "},StringSplitOptions.RemoveEmptyEntries);
                var countryName = commandParams[0];
                var spyName = commandParams[1];
                var daysInService = int.Parse(commandParams[2]);

                if (!result.ContainsKey(countryName))
                {
                    result[countryName] = new Dictionary<string, int>();
                }
                if (!result[countryName].ContainsKey(spyName))
                {
                    result[countryName][spyName] = new Int32();
                }

                result[countryName][spyName]+=daysInService;
                
            }

            //var result = new Dictionary<string, Dictionary<string, int>>();

            
            result = result.OrderByDescending(s => s.Value.Keys.Count)
                .ToDictionary(s => s.Key, s => s.Value);

            
            foreach (var country in result)
                {
                    Console.WriteLine($"Country: {country.Key}");
                    
                    foreach (var soldier in country.Value)
                    {
                        Console.WriteLine($"**{soldier.Key} : {soldier.Value}");
                    }
                }
        }
    }
}
