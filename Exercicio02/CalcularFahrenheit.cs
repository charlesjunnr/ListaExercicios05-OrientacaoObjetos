﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class CalcularFahrenheit
    {
        public double fahrenheit;
        public double celcius;
        
        public double ConverterFahrenheitParaCelsius()
        {
            celcius = (fahrenheit - 32) / 1.8;
            celcius = Math.Round(celcius, 2);
            return celcius;
        }
        

    }
}
