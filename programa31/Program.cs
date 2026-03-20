//Fecha: 12/2/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1
/* Se requiere un menu de opciones que permita el siguiente caso:
-Convertir kilometros a metros.
-Convertir grados centigrados a fahrenheit.
-Convertir litros a galones.
-Obtener el factorial de un numero. */

using System;
namespace convertir
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0;
            Console.WriteLine("Selecciona una opcion");
            Console.WriteLine("1. Convertir kilometros a metros.");
            Console.WriteLine("2. Convertir grados centigrados a fahrenheit.");
            Console.WriteLine("3. Convertir litros a galones.");
            Console.WriteLine("4. Obtener el factorial de un numero.");
            opcion=Convert.ToInt32(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    double kilometros=0,metros=0;
                    Console.WriteLine("Ingresa los kilometros");
                    kilometros=Convert.ToDouble(Console.ReadLine());
                    metros=kilometros*1000;
                    Console.WriteLine(kilometros+" kilometros son "+metros+" metros");
                break;
                case 2:
                    double centigrados=0,fahrenheit=0;
                    Console.WriteLine("Ingresa los grados centigrados");
                    centigrados=Convert.ToDouble(Console.ReadLine());
                    fahrenheit=(centigrados*9/5)+32;
                    Console.WriteLine(centigrados+" grados centigrados son "+fahrenheit+" grados fahrenheit");
                break;
                case 3:
                    double litros=0,galones=0;
                    Console.WriteLine("Ingresa los litros");
                    litros=Convert.ToDouble(Console.ReadLine());
                    galones=litros*0.264172;
                    Console.WriteLine(litros+" litros son "+galones+" galones");
                break;
                case 4:
                    int numero=0,factorial=1;
                    Console.WriteLine("Ingresa un numero");
                    numero=Convert.ToInt32(Console.ReadLine());
                    for(int i=1;i<=numero;i++)
                    {
                        factorial=factorial*i;
                    }
                    Console.WriteLine("El factorial de "+numero+" es "+factorial);
                break;
                default:
                    Console.WriteLine("Opcion no valida");
                break;
            }
        }
    }
}