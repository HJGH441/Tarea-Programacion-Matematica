using System;
namespace Pruebas
{
    public class Datos
    {
        public static void PedirDatos()
        {
            Console.Write("Igrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Igrese su Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Igrese la carrera que esta estudiando: ");
            string carrera = Console.ReadLine();
            
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("usted tiene  " + edad + " años de edad");
            Console.WriteLine("Usted estudia:  " + carrera);
        }
    }
}