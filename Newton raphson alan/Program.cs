using System;

namespace Newton_raphson_alan
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x = 3.0;
            double tolerancia = 0.0001;
            int maxIter = 20;

            for (int i = 1; i <= maxIter; i++)
            {
                double fx = (x * x * x) - (5 * x) - 20;
                double dfx = (3 * (x * x)) - 5;

                if (Math.Abs(dfx) <= 0)
                {
                    Console.WriteLine("Hay un problema con la derivada");
                    break;
                }

                double nuevoX = x - (fx / dfx);
                double error = Math.Abs(nuevoX - x);

                Console.WriteLine("Numero de iteracion : " + i);
                Console.WriteLine("X es igual a : " + x);
                Console.WriteLine("Fx es igual a : " + fx);
                Console.WriteLine("Dfx es igual a : " + dfx);
                Console.WriteLine("nuevoX es igual a : " + nuevoX);
                Console.WriteLine("error es igual a : " + error);

                if (error < tolerancia)
                {
                    Console.WriteLine("El valor final de Xn es : " + nuevoX);
                    break;
                }

                x = nuevoX;
            }
        }
    }
}