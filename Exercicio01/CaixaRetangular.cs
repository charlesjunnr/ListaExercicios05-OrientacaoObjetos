using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio01
{
    internal class CaixaRetangular
    {
        public int altura;
        public int comprimento;
        public int largura;

        public decimal CalcularVolume()
        {
            return altura * comprimento * largura;
        }
    }
}
