//Fecha: 30/01/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Pide al usuario dos números y muestra su resultado */

using System;
namespace numeroMostrar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res;

            Console.WriteLine("Ingrese el primer número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            res = n1 + n2;

            Console.WriteLine("El resultado de la suma es: " + res);
        }
    }
}