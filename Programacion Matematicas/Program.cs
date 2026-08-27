using System;

namespace Programacion_Matematicas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x = 0.9;
            double tolerancia = 0.0001;
            int maximo_iteraciones = 20;
            
            for(int i = 1; i <= maximo_iteraciones; i++)
            {
                double fx = ((60 * (x * x)) + 50 * x - 100);
                double dfx = (120 * x + 50);
                if (Math.Abs(dfx) <= 0)
                {
                    Console.WriteLine("Hay un problema con la derivada");
                    break;
                }

                double nuevo_x = x - (fx / dfx);
                double error = Math.Abs(nuevo_x - x);
                Console.WriteLine("Numero de iteracion : " + i);
                Console.WriteLine("X es igual a : " + x);
                Console.WriteLine("Fx es igual a : " + fx);
                Console.WriteLine("Dfx es igual a : " + dfx);
                Console.WriteLine("nuevo_x es igual a : " + nuevo_x);
                Console.WriteLine("error es igual a : " + error);
                if (error < tolerancia)
                {
                    Console.WriteLine("El valor final de Xn es : " + nuevo_x);
                    break;
                }
                x = nuevo_x;
            }

        }
    }
}