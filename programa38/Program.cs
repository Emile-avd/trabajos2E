//Fecha: 3/3/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//Version:1

/*utilizando recursividad hacer un programa que permita mostrar dos numero desde 0 hasta el numero que el usuario indique con un incremento que sera 
-indicado Tambien por el usuario.*/
using System;
using System.Text.RegularExpressions;
namespace funcionesRecursivas
{
    class ProgramaRecursividad
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Ingresa un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("Ingresa el incremento: ");
            int incremento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int resultado = 0;
                Recursividad(numero, incremento, resultado);
            Console.WriteLine("Fin del programa");
        }

        static void Recursividad(int numero, int incremento, int resultado)
        {
            if (resultado <= numero)
            {
                Console.WriteLine( resultado);
                resultado += incremento;
                Recursividad(numero, incremento, resultado);
            }
            return;
        }
    }
}
