using adventofcode.Interfaces;
using System;
using System.Linq;

namespace adventofcode.Challanges._2019
{
    public class Day02Part2 : IChallange
    {
        private readonly IIntcodeService _intcodeService;

        public int Year => 2019;

        public int Day => 2;

        public int Part => 2;

        public Day02Part2(IIntcodeService intcodeService)
        {
            _intcodeService = intcodeService;
        }

        public void Execute()
        {
            var codes = Day02Inputs.Inputs;

            codes[1] = 12;
            codes[2] = 2;

            Console.WriteLine($"Result: { _intcodeService.FindNounAndVerb(19690720, codes) }");
        }  
    }
}

