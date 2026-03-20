//Fecha: 05/02/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Utilizar el operador ternario en condiciones */

using System;
namespace opTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero cualquiera: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string r=(num%2==0)?"par":"impar";
            Console.WriteLine(r);
        }
    }
}