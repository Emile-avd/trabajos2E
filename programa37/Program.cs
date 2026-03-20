//Fecha: 30/01/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* usando recursividad desarrolle un programa que solicite un numero al usuario y
muestre la serie de numeros desde el numero que ingreso el usuario hasta 0*/

using System;
using System.Security.AccessControl;
namespace recursividad_Sucesion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Sucesion(numero);
        }

        static int Sucesion(int numero)
        {
            if (numero > 0)
            {
                Console.WriteLine(numero);
                return Sucesion(numero - 1);
            }
            return 0;
        }
    }
}
           