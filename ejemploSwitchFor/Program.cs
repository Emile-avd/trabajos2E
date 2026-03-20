//Fecha: 10/02/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/*  */

using System;
namespace tiendaDescuentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=0,i=0;
            Console.WriteLine("Ingresa una opcion");
            op=Convert.ToInt32(Console.ReadLine());
            switch(op)
            {
                case 1:
                    Console.WriteLine("Hola!!");
                break;
                case 2:
                    for(i=1;i<=10;i++)
                    {
                        Console.WriteLine("Salu2"+i);
                    }
                break;
                default:
                    {
                        Console.WriteLine("Opcion invalida");
                    }
                break;
            }
            
        }
    }
}