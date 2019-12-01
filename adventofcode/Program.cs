using adventofcode.Interfaces;
using Autofac;
using System;
using System.Linq;
using System.Reflection;

namespace adventofcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
                builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();

            var container = builder.Build();

            var challanges = container.Resolve<IChallange[]>()
                .ToList()
                .OrderByDescending(x => x.Year)
                .ThenByDescending(x => x.Day)
                .ToArray();

            while(true)
            {
                for (int i = 0; i < challanges.Length; i++)
                {
                    Console.WriteLine($"[{i}] { challanges[i].Year } - Day { challanges[i].Day }");
                }

                Console.Write("Select challange: ");
                var input = Console.ReadLine();

                if (input == "exit")
                    break;

                if (int.TryParse(input, out var index) && index < challanges.Length)
                {
                    challanges[index].Execute();
                    break;
                }

                Console.WriteLine($"Bad input: {input }, try again");
            }
        }
    }
}
