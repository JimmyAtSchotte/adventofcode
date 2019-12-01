using ArrangeDependencies.Autofac;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using adventofcode.Interfaces;
using adventofcode.Services;
using adventofcode.Challanges._2019;
using System.Linq;

namespace tests.Services
{
    [TestFixture]
    public class FuelCalulatorServiceTests
    {
        [TestCase(12, ExpectedResult = 2)]
        [TestCase(14, ExpectedResult = 2)]
        [TestCase(1969, ExpectedResult = 654)]
        [TestCase(100756, ExpectedResult = 33583)]
        public int CalculateMass(int mass)
        {
            var arrange = Arrange.Dependencies<IFuelCalculatorService, FuelCalculatorService>();
            var fuelCalculatorService = arrange.Resolve<IFuelCalculatorService>();

            return fuelCalculatorService.FromMass(mass);
        }

        [Test]
        public void CalulateMassWithFuel()
        {
            var arrange = Arrange.Dependencies<IFuelCalculatorService, FuelCalculatorService>();
            var fuelCalculatorService = arrange.Resolve<IFuelCalculatorService>();

            var totalFuel = Day01Inputs.Inputs.Sum(x => fuelCalculatorService.FromMassAndFuel(x));

            

            Assert.AreEqual(5102369, totalFuel);
        }
    }
}
