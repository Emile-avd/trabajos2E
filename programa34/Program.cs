//Fecha: 3/3/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//Version:1

using System;
using System.Text.RegularExpressions;
namespace funcionesRecursivas
{
    class ProgramaRecursividad
    {
        static void Main(String[]args)
        {
            int entrada=0;
            int salida=0;
                //RECURSIVIDAD
                /*Es una tecnica una funcion se llama a si misma  para
                resolver problemas dividiandolos en subprogramas mas pequeños.
                Requiere un caso base (Condiciones de parada) para evitar bucles
                infinitos y un caso recursivo que reduce el problema en cada
                llamada.*/
            Console.WriteLine("CALCULA EL FACTORIAL RECURSIVIDAD");
            Console.WriteLine("Ingresa el numero de quien desdea calcular el factorial: ");
            entrada = Convert.ToInt32(Console.ReadLine());
            salida=CalculaFactorial(entrada);
            Console.WriteLine("El Factorial de "+entrada+" es "+salida);


            //realizare la funcion
            static int CalculaFactorial(int numero)
            {
                int factorial;

                if (numero == 0)
                {
                    return 1;
                }
                else
                {
                    factorial=numero*CalculaFactorial(numero-1);
                    Console.WriteLine(factorial);
                    return factorial;
                }
            }
        }
    }
}