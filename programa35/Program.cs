//Fecha: 3/3/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//Version:1

using System;
using System.Text.RegularExpressions;
namespace seriesRecursivas
{
    class ProgramaRecursividad
    {
        static void Main(String[]args)
        {
            char op;
           do {
            Console.Clear();
            int entrada=0;
            int salida=0;
            Console.WriteLine("CALCULA LA SUCESION DE FIBONACCI");
            Console.WriteLine("Ingresa el numero de posicion: ");
            entrada = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nSUCESION DE FIBONACCI hasta la posicion " + entrada + ":");
            salida = CalculaFibonacci(entrada);
            Console.WriteLine("\nEl numero de Fibonacci en la posicion " + entrada + " es " + salida);


            //realizare la funcion
            static int CalculaFibonacci(int posicion)
            {
                if (posicion == 0)
                {
                    Console.WriteLine(0);
                    return 0;
                }
                else if (posicion == 1)
                {
                    Console.WriteLine(1);
                    return 1;
                }
                
                int anterior = 0;
                int actual = 1;
                
                for (int i = 2; i <= posicion; i++)
                {
                    int siguiente = anterior + actual;
                    Console.WriteLine(siguiente);
                    anterior = actual;
                    actual = siguiente;
                }
                
                return actual;
            }
            
            Console.WriteLine("\nOtro? (si/no)");
            op = char.Parse(Console.ReadLine().ToUpper());
            }while(op == 'S');
        }
    }
}