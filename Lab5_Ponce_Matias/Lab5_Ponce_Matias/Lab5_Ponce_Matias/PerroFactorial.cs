using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Ponce_Matias
{
    class PerroFactorial : ICalcular
    {
        public int Calcular(int numero)
        {
            if (numero > 12)
            {
                numero = 13;
            }

            int valor = 1;

            if (numero == 0)
                valor = 0;

            for (int i = 1; i < numero + 1; i++)
            {
                valor *= i;
            }

            return valor;
        }
    }
}
