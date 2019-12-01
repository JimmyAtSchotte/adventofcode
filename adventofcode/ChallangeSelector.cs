using adventofcode.Interfaces;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace adventofcode
{
    public class ChallangeSelector : IChallangeSelector
    {
        private readonly IChallange[] _challanges;

        public ChallangeSelector(IChallange[] challanges)
        {
            _challanges = challanges;
        }

        public IChallange Select()
        {
            var challanges = _challanges
                .ToList()
                .OrderByDescending(x => x.Year)
                .ThenByDescending(x => x.Day)
                .ThenBy(x => x.Part)
                .ToArray();

            while (true)
            {
                for (int i = 0; i < challanges.Length; i++)
                    Console.WriteLine($"[{i}] { challanges[i].Year } - Day { challanges[i].Day } - Part { challanges[i].Part }");

                Console.Write("Select challange: ");
                var input = Console.ReadLine();

                if (input == "exit")
                    break;

                if (int.TryParse(input, out var index) && index < challanges.Length)                
                    return challanges[index];
                

                Console.WriteLine($"Bad input: {input }, try again");
            }

            return null;
        }
    }
}
