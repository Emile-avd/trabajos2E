//Fecha: 05/02/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Clasificar un numero como positivo, negativo o 0 */

using System;
namespace clasificarNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero cualquiera: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num>0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else if(num<0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es 0");
            }
        }
    }
}