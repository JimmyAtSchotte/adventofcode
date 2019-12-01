using System;
using System.Collections.Generic;
using System.Text;

namespace adventofcode.Interfaces
{
    public interface IChallange
    {
        int Year { get; }
        int Day { get; }
        int Part { get; }
        
        void Execute();
    }
}
