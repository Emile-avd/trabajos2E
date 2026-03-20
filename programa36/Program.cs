//Fecha: 30/01/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/*1.-Arreglo estatico que guarda 10 nombres de estudiantes y los muestra
  2.-Arreglo estatico que solicite y guarde 10 calificaciones,
   obtener el promedio y muestre las calificaciones guasrdadas
  3.-Arreglo dinamico que solicite, guarde y muestre 5 nombres de frutas
  4.-Arreglo estatico que solicite y guerde 5 numeros y los mostrara en orden inverso  */

using System;
namespace numFlotanteMultiplicarPorDos
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                int op1=0;
                    Console.WriteLine("Elige una opcion:   ");
                    Console.WriteLine("1.Arreglo estatico que guarda 10 nombres de estudiantes y los muestra");
                    Console.WriteLine("2.Arreglo estatico que solicite y guarde 10 calificaciones, obtener el promedio y mostrar las calificaciones guardadas");
                    Console.WriteLine("3.Arreglo dinamico que solicite, guarde y muestre 5 nombres de frutas");
                    Console.WriteLine("4.Arreglo estatico que solicite y guarde 5 numeros y los muestre en orden inverso");
                    Console.WriteLine("5.Salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.Clear();
                            string[] array = {"Juan", "María", "Pedro", "Ana", "Luis", "Sofía", "Carlos", "Lucía", "Miguel", "Valentina"};
                            Console.WriteLine("Nombres de los estudiantes:");
                            Console.WriteLine("---------------------------");
                            Program.StrMostrarArray(array);
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            double[] calificaciones = new double[10];
                            Console.WriteLine("Ingrese 10 calificaciones:");
                            Program.DoubleIngresarArray(calificaciones);
                            double suma = 0;
                            for (int i = 0; i < calificaciones.Length; i++)
                            {
                                suma += calificaciones[i];
                            }
                            double promedio = suma / calificaciones.Length;
                            Console.WriteLine("Calificaciones guardadas:");
                            Program.DoubleMostrarArray(calificaciones);
                            Console.WriteLine($"Promedio: {promedio}");
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            string[] frutas = new string[5];
                            for (int i = 0; i < frutas.Length; i++)
                            {
                                Console.Write("Ingrese el nombre de la fruta {0}: ", i + 1);
                                frutas[i] = Console.ReadLine();
                            }
                            Console.WriteLine("\nLos nombres de las frutas ingresadas son:");
                            Program.StrMostrarArray(frutas);
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            int[] numeros = new int[5];
                            Console.WriteLine("Ingrese 5 números:");
                            Program.IntIngresarArray(numeros);
                            Console.WriteLine("\nNúmeros en orden inverso:");
                            Program.IntMostrarArrayInverso(numeros);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Saliendo del programa...");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 5.");
                        }
                        break;
                }
            }while(op != 5);
        }

        static void StrMostrarArray(string[] array)
        {
            Console.WriteLine("Nombres de los elementos:");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {array[i]}");
            }
        }

        static void StrIngresarArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ingrese el elemento {i + 1}: ");
                array[i] = Console.ReadLine();
            }
        }

        
        static void IntIngresarArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ingrese el elemento {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        
        static void DoubleIngresarArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ingrese el elemento {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }
        }

        static void DoubleMostrarArray(double[] array)
        {
            Console.WriteLine("Calificaciones guardadas:");
            Console.WriteLine("------------------------");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {array[i]}");
            }
        }

        static void IntMostrarArrayInverso(int[] array)
        {
            Console.WriteLine("Números en orden inverso:");
            Console.WriteLine("------------------------");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
    }
}