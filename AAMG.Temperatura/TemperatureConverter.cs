using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAMG.Temperatura
{
    public class TemperatureConverter
    {
        public double CelciusToFarenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double FarenheitToCelcius(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }


    }
}
