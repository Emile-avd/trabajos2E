//Fecha: 05/02/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Comprobar si un numero esta dentro de; rango */

using System;
namespace rango10a25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero cualquiera: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num>=10 && num<=25)
            {
                Console.WriteLine("El numero esta dentro del rango");
            }
            else
            {
                Console.WriteLine("El numero no esta en el rango");
            }
        }
    }
}