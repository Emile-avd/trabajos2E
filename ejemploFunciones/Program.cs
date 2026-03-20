//Fecha: 24/2/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Calcula el area de un circulo con funciones */
using System;
namespace ejemploFunciones
{
    class ProgramaFunciones
    {
        static void Main(String[]args)
        {
            double entrada = 0, salida = 0;

            //RETORNANDO LA SALIDA
            Console.WriteLine("Calcula el area de un circulo");
            Console.WriteLine("Ingresa el valor del radio: ");
            entrada = Convert.ToDouble(Console.ReadLine());
            //Llamare a la funcion instanciando la clase para calcular el area de un circulo
            salida=ProgramaFunciones.CalculaAreaCirculo(entrada);
            Console.WriteLine("El area del circulo es: "+salida);

            //SIN RETORNAR
            Console.WriteLine("Calcula el area de un circulo");
            Console.WriteLine("Ingresa el valor del radio: ");
            entrada=Convert.ToDouble(Console.ReadLine());
            ProgramaFunciones.CalculaAreaCirculo2(entrada);

            //SIN ENTRADAS NI SALIDAS
            ProgramaFunciones.CalculaAreaCirculo3();
        }

        //FUCIONES FUERA DEL PROGRAMA PRINCIPAL

        static double CalculaAreaCirculo(double radio)
        {
            double area = 0;
            area=3.1416*radio*radio;
            return area;
        }

        static void CalculaAreaCirculo2(double radio)
        {
            double area = 0;
            area=3.1416*radio*radio;
            Console.WriteLine("El area del circulo es: "+area);
        }
        static void CalculaAreaCirculo3()
        {
            double entrada=0,area=0;
            Console.WriteLine("Calcula el area de un circulo");
            Console.WriteLine("Ingresa el valor del radio: ");
            entrada=Convert.ToDouble(Console.ReadLine());
            area=3.1416*entrada*entrada;
            Console.WriteLine("El area del circulo es: "+area);
        }
    }
}