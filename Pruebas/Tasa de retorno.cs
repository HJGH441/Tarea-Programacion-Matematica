using System;

namespace Pruebas
{
    public class Tasa_de_retorno
    {
        public static void CalcularTasa()
        {
            Console.WriteLine("Calculadora de tasa de retorno");
            Console.Write("Ingresa la inversion inicial: ");
            double Inversion_inicial = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la Ganancia Final: ");
            double GananciaFinal = Convert.ToDouble(Console.ReadLine());
            double tasa = ((GananciaFinal - Inversion_inicial) / Inversion_inicial)* 100;
            Console.WriteLine("La tasa de retorno es de : " + tasa);
        }
    }
}