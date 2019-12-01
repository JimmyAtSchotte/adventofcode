using System;
using System.Collections.Generic;
using System.Text;

namespace adventofcode.Interfaces
{
    public interface IFuelCalculatorService
    {
        int FromMass(int mass);

        int FromMassAndFuel(int mass);
    }
}
