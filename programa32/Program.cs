//Fecha: 12/2/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Se solicita la edad al usuario, si la edad es mayor o igual a 18, se muestra un mensaje indicando 
que diga "mayor de edad", en caso contrario se debera saludar el numero de veces correspondiente a la 
edad */
using System;
namespace mayordeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ResetColor();
            int op = 0;
            do
            {

                Console.WriteLine("Elige un programa a ejecutar:");
                Console.WriteLine("1.-Programa 29");
                Console.WriteLine("2.-Programa 30");
                Console.WriteLine("3.-Programa 31");
                Console.WriteLine("4.-Salir");
                op = Convert.ToInt32(Console.ReadLine()); 
                switch(op)
                {
                    case 1:
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            int edad=0,i=0;
                            Console.WriteLine("Ingresa tu edad");
                            edad=Convert.ToInt32(Console.ReadLine());
                            if(edad>=18)
                            {
                                Console.WriteLine("Eres mayor de edad");
                            }
                            else
                            {
                                for(i=1;i<=edad;i++)
                                {
                                    Console.WriteLine("Hola "+i);
                                }
                            }
                        }
                    break;
                    case 2:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
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
                    break;
                    case 3:
                        {
                            Console.BackgroundColor = ConsoleColor.Magenta;
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
                    break;
                    case 4:
                        {
                            Console.WriteLine("Gracias por su visita :D");
                        }
                    break;
                    default:
                        {
                            Console.WriteLine("Opcion no valida!!!");
                        }
                    break;
                } 

            }
            while(op != 4);
        }
    }
}