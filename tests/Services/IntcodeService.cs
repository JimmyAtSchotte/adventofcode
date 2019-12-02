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
    public class IntcodeServiceTests
    {
        [Test]
        public void ProcessCodeList_AdditionOpCode()
        {
            var arrange = Arrange.Dependencies<IIntcodeService, IntcodeService>();
            var intcodeService = arrange.Resolve<IIntcodeService>();

            var codes = new[] { 1, 0, 0, 0, 99 };
            var expected = new[] { 2, 0, 0, 0, 99 };

            var result = intcodeService.ProcessCodeList(codes);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ProcessCodeList_MultplierOpCode()
        {
            var arrange = Arrange.Dependencies<IIntcodeService, IntcodeService>();
            var intcodeService = arrange.Resolve<IIntcodeService>();

            var codes = new[] { 2, 3, 0, 3, 99 };
            var expected = new[] { 2, 3, 0, 6, 99 };

            var result = intcodeService.ProcessCodeList(codes);
           
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ProcessCodeList_HaltOpCode()
        {
            var arrange = Arrange.Dependencies<IIntcodeService, IntcodeService>();
            var intcodeService = arrange.Resolve<IIntcodeService>();

            var codes = new[] { 2, 4, 4, 5, 99, 0 };
            var expected = new[] { 2, 4, 4, 5, 99, 9801 };

            var result = intcodeService.ProcessCodeList(codes);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ProcessCodeList_OverideOpCode()
        {
            var arrange = Arrange.Dependencies<IIntcodeService, IntcodeService>();
            var intcodeService = arrange.Resolve<IIntcodeService>();

            var codes = new[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 };
            var expected = new[] { 30, 1, 1, 4, 2, 5, 6, 0, 99 };

            var result = intcodeService.ProcessCodeList(codes);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FindNounAndVerb()
        {
            var arrange = Arrange.Dependencies<IIntcodeService, IntcodeService>();
            var intcodeService = arrange.Resolve<IIntcodeService>();

            var codes = new[] { 2, 0, 0, 0, 99 };

            var result = intcodeService.FindNounAndVerb(198, codes);

            Assert.AreEqual("0004", result);
        }

    }
}
