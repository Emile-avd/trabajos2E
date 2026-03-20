//Fecha: 12/2/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1
/* Se requiere un menu de opciones que permita el siguiente caso:
-Obtener la media de 200 numeros dados por el usuario.
-Calcular el area y perimetro de un triangulo equilatero.
-Obtener el 15% de descuento de una compra, mostrar la compra, el descuento y el total a pagar.
-Indicar si un numero dado por el usuario es par o impar */

using System;
namespace opcionesFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0;
            Console.WriteLine("Selecciona una opcion");
            Console.WriteLine("1. Obtener la media de 5 numeros.");
            Console.WriteLine("2. Calcular el area y perimetro de un triangulo equilatero.");
            Console.WriteLine("3. Obtener el 15% de descuento de una compra, mostrar la compra, el descuento y el total a pagar.");
            Console.WriteLine("4. Indicar si un numero dad por el usuario es par o impar");
            opcion=Convert.ToInt32(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    {
                        double numero=0,media=0;
                        for(int i=1;i<=5;i++)
                        {
                            Console.WriteLine("Ingresa un numero");
                            numero=Convert.ToDouble(Console.ReadLine());
                            media=media+numero;
                        }
                        media=media/5;
                        Console.WriteLine("La media es: "+media);
                    }
                break;
                case 2:
                    {
                        double lado=0,area=0,perimetro=0,altura=0;
                        Console.WriteLine("Ingresa el lado del triangulo");
                        lado=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa la altura");
                        altura=Convert.ToDouble(Console.ReadLine());
                        area=lado*altura/2;
                        perimetro=lado*3;
                        Console.WriteLine("El area es: "+area);
                        Console.WriteLine("El perimetro es: "+perimetro);
                    }
                break;
                case 3:
                    {
                        double compra=0,descuento=0,total=0;
                        Console.WriteLine("Ingresa el total de la compra");
                        compra=Convert.ToDouble(Console.ReadLine());
                        descuento=compra*0.15;
                        total=compra-descuento;
                        Console.WriteLine("Compra: $"+compra);
                        Console.WriteLine("Descuento: $"+descuento);
                        Console.WriteLine("Total a pagar: $"+total);   
                    }
                break;
                case 4:
                    {
                        int numero2=0;
                        Console.WriteLine("Ingresa un numero");
                        numero2=Convert.ToInt32(Console.ReadLine());
                        if(numero2%2==0)
                        {
                            Console.WriteLine("El numero es par");
                        }
                        else
                        {
                            Console.WriteLine("El numero es impar");
                        }
                    }
                break;
                default:
                    {
                        Console.WriteLine("Opcion no valida");      
                    }
                break;
            }
        }
    }
}