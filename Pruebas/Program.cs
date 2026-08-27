using System;

namespace Pruebas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quiere Sumar, Restar, Multiplicar o Dividir: ");
            string x =  Console.ReadLine();

            if (x == "sumar")
            {
                double suma = Calcular.Sumar(a, b);
                Console.WriteLine("El resultado de su suma es: "+ suma);
            }
            else if (x == "restar")
            {
                double resta = Calcular.Restar(a, b);
                Console.WriteLine("El resultado de su resta es: "+ resta);
            }
            else if (x == "multiplicar")
            {
                double multiplicacion = Calcular.Multiplicar(a, b);
                Console.WriteLine("El resultado de multiplicacion es: " + multiplicacion);
            } 
            else if (x == "dividir")
            {
                double dividir = Calcular.Dividir(a, b);
                Console.WriteLine("El resultado de dividir es: " + dividir);
            }
            else
            {
                Console.WriteLine("Error por favor elija correctamente.");
            }
        }
    }
}