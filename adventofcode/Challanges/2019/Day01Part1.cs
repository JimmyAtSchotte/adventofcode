using adventofcode.Interfaces;
using System;
using System.Linq;

namespace adventofcode.Challanges._2019
{
    public class Day01Part1 : IChallange
    {
        private readonly IFuelCalculatorService _fuelCalculatorService;

        public int Year => 2019;

        public int Day => 1;

        public int Part => 1;

        public Day01Part1(IFuelCalculatorService fuelCalculatorService)
        {
            _fuelCalculatorService = fuelCalculatorService;
        }

        public void Execute()
        {
            Console.WriteLine($"Result: { Day01Inputs.Inputs.Sum(x => _fuelCalculatorService.FromMass(x)) }");
        }  
    }
}

