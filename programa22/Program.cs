//Fecha: 05/02/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Determinar si un numero es par o impar */

using System;
namespace numParImp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero cualquiera: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num%2==0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}