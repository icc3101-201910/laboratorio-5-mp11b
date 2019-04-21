using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Ponce_Matias
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BIENVENIDO A CALCULATOR");
            while (true)
            { 
                Console.Write("Ingrese el número que desea evaluar: ");
                int numero = int.Parse(Console.ReadLine()); // Se asigna un numero a evaluar
                Console.Write("\n");

                Calculadora calculadora = new Calculadora(numero);
             
                Console.WriteLine("Ingrese el numero de la operacion que desea realizar: ");
                Console.WriteLine("[1] Suma 5 ");
                Console.WriteLine("[2] Factorial");
                Console.WriteLine("[3] Fibonacci");
                Console.WriteLine("[4] Cuadrado");
                Console.WriteLine("[5] Cubo");
                Console.WriteLine("[6] Salir\n");

                Console.Write("Opcion: ");
                string op = Console.ReadLine(); // Se elige la opcion a escoger
                Console.Write("\n");

                if (op == "1")
                {
                    calculadora.calculadoras.Add(new PersonaQueSuma5());
                    Console.WriteLine($"Resultado: {calculadora.Calcular()}\n");
                }
                else if (op == "2")
                {
                    calculadora.calculadoras.Add(new PerroFactorial());
                    Console.WriteLine($"Resultado: {calculadora.Calcular()}\n");
                }
                else if (op == "3")
                {
                    calculadora.calculadoras.Add(new RobotFibonacci());
                    Console.WriteLine($"Resultado: {calculadora.Calcular()}\n");
                }
                else if (op == "4")
                {
                    calculadora.calculadoras.Add(new Cuadrado());
                    Console.WriteLine($"Resultado: {calculadora.Calcular()}\n");
                }
                else if (op == "5")
                {
                    calculadora.calculadoras.Add(new Cubo());
                    Console.WriteLine($"Resultado: {calculadora.Calcular()}\n");
                }
                else if (op == "6")
                {
                    break;
                }
            }
        }
    }
}
