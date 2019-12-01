using adventofcode.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace adventofcode.Services
{
    public class FuelCalculatorService : IFuelCalculatorService
    {
        public int FromMass(int mass)
        {
            return mass / 3 - 2;
        }

        public int FromMassAndFuel(int mass)
        {
            var totalFuel = 0;
            
            var fuel = FromMass(mass);

            while (fuel > 0)
            {
                totalFuel += fuel;
                fuel = FromMass(fuel);
            }

            return totalFuel;

        }
    }
}
