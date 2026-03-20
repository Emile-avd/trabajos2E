//Fecha: 30/01/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Convierte una variable de tipo int a float y viceversa */

using System;
namespace conversionIntFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convertir int a float
            int entero = 10;
            float flotante = entero;
            Console.WriteLine(flotante);
            
            // Convertir float a int
            float flotante2 = 10.5f;
            int entero2 = (int)flotante2;
            Console.WriteLine(entero2);
        }
    }
}