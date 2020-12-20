using NUnit.Framework;

//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NUnitNumbers.Test
{
    [TestFixture]
    //should be class followed by test
    //see Program.cs
    public class MathsHelper
    {
        [Test]
        public int Add(int num1, int num2)
        {
            //Arrange
            MathsHelper helper = new MathsHelper();

            //Act
            var result = helper.Add(20, 10);

            //Assert
            Assert.AreEqual(30, result);
            return result;
        }

        [Test]
        public int Subtract(int num1, int num2)
        {
            MathsHelper helper = new MathsHelper();
            var result = helper.Subtract(20, 10);
            Assert.Equals(10, result);
            return result;
            //add library for math tomomorrow
        }
    }
}
