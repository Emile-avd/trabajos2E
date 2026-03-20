//Fecha: 30/01/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Declara una variable con tipo de dato implicito y obten
el tipo de dato de la misma */

using System;
namespace tipoDatoImplicito
{
    class Program
    {
        static void Main(string[] args)
        {
            var numero = 25.5;
            Console.WriteLine("El tipo de variable es: " + numero.GetType());
        }
    }
}