using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECRC.Temperatura;

namespace ECRC.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        private readonly TemperatureConverter converter = new TemperatureConverter();

        [TestMethod]
        public void CelsiusToFahrenheit_ZeroCelsius_Returns32Fahrenheit()
        {
            double result = converter.CelsiusToFahrenheit(0);
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void FahrenheitToCelsius_32Fahrenheit_ReturnsZeroCelsius()
        {
            double result = converter.FahrenheitToCelsius(32);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_100Celsius_Returns212Fahrenheit()
        {
            double result = converter.CelsiusToFahrenheit(100);
            Assert.AreEqual(212, result);
        }

        [TestMethod]
        public void FahrenheitToCelsius_212Fahrenheit_Returns100Celsius()
        {
            double result = converter.FahrenheitToCelsius(212);
            Assert.AreEqual(100, result);
        }
    }
}
