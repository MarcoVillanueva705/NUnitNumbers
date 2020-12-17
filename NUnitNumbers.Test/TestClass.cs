﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NUnitNumbers.Test
{
    [TestClass]
    public class TestClass
    {
        [Test]
        public void AddTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Add(20, 10);
            Assert.AreEqual(30, result);
        }

        [TestCase]
        public void SubtractTest()
        {
            MathsHelper helper = new MathsHelper();
            int result = helper.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }
    }
}
