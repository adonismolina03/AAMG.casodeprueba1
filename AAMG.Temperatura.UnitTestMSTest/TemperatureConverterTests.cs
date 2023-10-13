using Microsoft.VisualStudio.TestTools.UnitTesting;
using AAMG.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAMG.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        [TestMethod()]
        public void CelciusToFarenheitTest()
        {

            TemperatureConverter converter = new TemperatureConverter();
            double celsius = 25;

            double result = converter.CelciusToFarenheit(celsius);

            Assert.AreEqual(77, result);
        }

        [TestMethod()]
        public void FarenheitToCelciusTest()
        {
            TemperatureConverter converter = new TemperatureConverter();
            double fahrenheit = 77; 

            
            double result = converter.FarenheitToCelcius(fahrenheit);

            
            Assert.AreEqual(25, result); 
        }
    }
}