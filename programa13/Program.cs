//Fecha: 30/01/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Pide al usuario un numero de punto flotante, multiplicalo por dos y muestra el resultado */

using System;
namespace numFlotanteMultiplicarPorDos
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, res;
            Console.WriteLine("Ingrese el primer número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            
            res = n1 * 2;

            Console.WriteLine("El resultado de multiplicar por dos es: " + res);
        }
    }
}