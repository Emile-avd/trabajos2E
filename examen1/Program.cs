//Autor: D.E.C
//Fecha: 2/17/2026
//CUtrimestre y grupo:2E
//Version: 1

/*examen*/

using System;
using System.Diagnostics.Contracts;
namespace Examen1
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Elige una opcion");
            Console.WriteLine("1.-Solicitar nombre completo");
            Console.WriteLine("2.-Solicitar edad");
            Console.WriteLine("3.-Calcular el total a pagar de una compra");
            int op = Convert.ToInt32(Console.ReadLine());
            switch(op)
            {
                case 1:
                    {
                        Console.WriteLine("Nombre:");
                        string nombre = Console.ReadLine().ToUpper();
                        int car1 = nombre.Length;
                        Console.WriteLine("Apellido paterno:");
                        string apellidoP = Console.ReadLine().ToUpper();
                        int car2 = apellidoP.Length;
                        Console.WriteLine("Apellido materno:");
                        string apellidoM = Console.ReadLine().ToUpper();
                        int car3 = apellidoM.Length;
                        int res = car1+car2+car3+2;
                        Console.WriteLine(nombre+" "+apellidoP+" "+apellidoM);
                        Console.WriteLine("El total de caracteres es: "+res);   
                    }
                break;
                case 2:
                    {
                        int i = 0, edad=0;
                        Console.WriteLine("Ingresa tu edad: ");
                        edad = Convert.ToInt32(Console.ReadLine());
                        if (edad >= 18)
                        {
                            Console.WriteLine("Eres mayor de edad!!");
                        }
                        else
                        {
                            for (i=1;i<=edad;i++)
                            {
                                Console.WriteLine("HOLA!! "+i);
                            }
                        }
                    }
                break;   
                case 3:
                    {
                        double descuento=0, iva=0, totalP=0,compra=0;
                        Console.WriteLine("Ingresa el valor de tu compra: ");
                        compra = Convert.ToDouble(Console.ReadLine());
                        if(compra>=3000 && compra<=5000)
                        {
                            descuento=compra*.1;
                        }  
                        else if(compra > 5000)
                        {
                            descuento = compra*.30;    
                        }
                        iva=compra*.16;
                        totalP=compra-descuento+iva;
                        DateTime fechaAct = DateTime.Now;
                        Console.WriteLine("Fecha: "+fechaAct);
                        Console.WriteLine("Su compra fue de: "+compra);
                        Console.WriteLine("Descuento: "+descuento);
                        Console.WriteLine("IVA: "+iva);
                        Console.WriteLine("Total a pagar: "+totalP);
                    } 
                break;
                default:
                    {
                        Console.WriteLine("Opcione invalida");
                    }
                break;
            }
        }
    }
}