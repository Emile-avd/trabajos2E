//Fecha: 12/2/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Se solicita la edad al usuario, si la edad es mayor o igual a 18, se muestra un mensaje indicando 
que diga "mayor de edad", en caso contrario se debera saludar el numero de veces correspondiente a la 
edad */
using System;
namespace mayordeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad=0,i=0;
            Console.WriteLine("Ingresa tu edad");
            edad=Convert.ToInt32(Console.ReadLine());
            if(edad>=18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                for(i=1;i<=edad;i++)
                {
                    Console.WriteLine("Hola "+i);
                }
            }
        }
    }
}