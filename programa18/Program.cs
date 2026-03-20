//Fecha: 30/01/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Escribe un programa que tome una letra minuscula como entrada,
avance 3 posiciones en el alfabeto y muestre la nueva letra */

using System;
namespace letraAvanzar3Posiciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una letra:");
            char letra = Console.ReadKey().KeyChar;
            char posicion = (char)(letra + 3);
            Console.WriteLine("\nLa letra avanzada 3 posiciones es: "+posicion);

        }
    }
}