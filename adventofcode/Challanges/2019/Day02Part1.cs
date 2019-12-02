using adventofcode.Interfaces;
using System;
using System.Linq;

namespace adventofcode.Challanges._2019
{
    public class Day02Part1 : IChallange
    {
        private readonly IIntcodeService _intcodeService;

        public int Year => 2019;

        public int Day => 2;

        public int Part => 1;

        public Day02Part1(IIntcodeService intcodeService)
        {
            _intcodeService = intcodeService;
        }

        public void Execute()
        {
            var codes = Day02Inputs.Inputs;

            codes[1] = 12;
            codes[2] = 2;

            Console.WriteLine($"Result: { _intcodeService.ProcessCodeList(codes)[0] }");
        }  
    }
}

