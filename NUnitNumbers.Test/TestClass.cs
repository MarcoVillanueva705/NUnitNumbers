using System.Collections.Generic;
using NUnitNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NUnitNumbers.Test
{
    [TestClass]
    //should be class followed by test
    //see Program.cs
    public class MathsHelper
    {
        [TestMethod]
        public void AddTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Add(20, 10);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void SubtractTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }
    }
}
