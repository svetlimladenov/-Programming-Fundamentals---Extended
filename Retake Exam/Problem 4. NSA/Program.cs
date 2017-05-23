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
            var result = new Dictionary<string, Dictionary<string, long>>();

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
                var daysInService = long.Parse(commandParams[2]);
                if (daysInService < 0)
                {
                    continue;
                }
                if (!result.ContainsKey(countryName))
                {
                    result[countryName] = new Dictionary<string, long>();
                }
                if (!result[countryName].ContainsKey(spyName))
                {
                    result[countryName][spyName] = 0L;
                }

                result[countryName][spyName]+=daysInService;
                
            }

            //var result = new Dictionary<string, Dictionary<string, int>>();


            result = result
                .OrderByDescending(a => a.Value.Count)
                .ToDictionary(a => a.Key, a => a.Value);
            
            foreach (var country in result)
                {
                    Console.WriteLine($"Country: {country.Key}");

                var innerDic = country.Value
                    .OrderByDescending(k => k.Value)
                    .ToDictionary(k => k.Key, k => k.Value
                    );
                    foreach (var soldier in innerDic)
                    {
                        Console.WriteLine($"**{soldier.Key} : {soldier.Value}");
                    }
                }
        }
    }
}
