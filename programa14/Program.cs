//Fecha: 30/01/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Pide al usuario que escriba su nombre por consloa, obten el total de caracteres del nombre,
sumale un numero punto flotante y muestra el resultado */

using System;
namespace nombreCaracteresSumaPuntoFlotante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string nom = Console.ReadLine();
            int car = nom.Length;
            double res = car + 0.1;
            Console.WriteLine("El resultado es: " + res);
        }
    }
}