using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElenaLekomtsevaTestTaskMTC;
using System;

namespace ClassMTests
{
    [TestClass]
    public class ClassMUnitTests
    {

        [TestMethod]
        public void Sqrt_8value_2returned()
        {
            // Arrange
            double value = 4;
            double expected = 2;

            // Act
            double actual = ClassM.Sqrt(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sqrt_10value_2returned()
        {
            // Arrange
            double value = 10;
            double expected = 3.1623;

            // Act
            double actual = ClassM.Sqrt(value);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Sqrt_NegaTiveValue_CheckMessageReturned()
        {
            // Arrange
            double value = -4;
            string expected = "Невозможно извлечь квадратный корень из отрицательного числа";

            // Act
            string actual = "";
            try
            {
                ClassM.Sqrt(value);
            }
            catch (Exception e)
            {
                actual = e.Message;
            }

            // Assert
            StringAssert.Contains(actual, expected);
        }

        [TestMethod]
        public void Sqrt_NegaTiveValue_ArgumentNullExceptionReturned()
        {
            // Arrange
            double value = -4;

            // Act
            bool actual = false;
            try
            {
                ClassM.Sqrt(value);
            }
            catch (ArgumentOutOfRangeException e)
            {
                actual = true;
            }

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Sqrt_0value_0returned()
        {
            // Arrange
            double value = 0;
            double expected = 0;

            // Act
            double actual = ClassM.Sqrt(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
