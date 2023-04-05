using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class CalcularCilindro
    {
        public double altura, raio, volume, pi = 3.14;
        public double CalcularVolume()
        {
            raio = raio * raio;
            volume = pi * (altura * raio);
            return volume;
        }
    }
}
