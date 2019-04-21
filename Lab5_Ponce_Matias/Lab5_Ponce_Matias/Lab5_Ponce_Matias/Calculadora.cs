using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Ponce_Matias
{
    class Calculadora
    {
        private int numero;
        public List<ICalcular> calculadoras;

        public Calculadora(int numero)
        {
            this.numero = numero;
            calculadoras = new List<ICalcular>();
        }

        public int Calcular()
        {
            int result = 0;
            foreach (ICalcular calculator in calculadoras)
            {
               result += calculator.Calcular(GetNumero());
            }
            return result;
        }

        public int GetNumero()
        {
            return numero;
        }
    }
}
