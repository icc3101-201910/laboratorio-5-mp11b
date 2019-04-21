using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Ponce_Matias
{
    class RobotFibonacci : ICalcular
    {
        public int Calcular(int numero)
        {
            if (numero > 46)
            {
                numero = 46;
            }

            int num_anterior = 0;

            if (numero == 0)
                return num_anterior;

            int num_actual = 1;
            for (int i = 0; i < numero - 1; i++)
            {
                int aux = num_anterior;
                num_anterior = num_actual;
                num_actual = aux + num_anterior;
            }
            return num_actual;
        }
    }
}
