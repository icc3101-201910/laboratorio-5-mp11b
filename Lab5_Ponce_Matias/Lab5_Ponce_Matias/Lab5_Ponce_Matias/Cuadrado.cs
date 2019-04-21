using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Ponce_Matias
{
    class Cuadrado : ICalcular
    {
        public int Calcular(int numero)
        {
            return numero*numero;
        }
    }
}
