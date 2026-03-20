//Fecha: 05/02/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Verificar si un numero es mayor que 10 */

using System;
namespace numMayora10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero cualquiera: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num>10)
            {
                Console.WriteLine("El numero es mayor o igual a 10");
            }
            else
            {
                Console.WriteLine("El numero es menor que 10");
            }
        }
    }
}