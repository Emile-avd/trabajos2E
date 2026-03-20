//Fecha: 05/02/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Se otorgan becas de cauerdo a la edad y genero de los estudiantes basandose en las siguientes condiciones:
-Si tiene entre 17 y 20 años se le pagaran 1800 por semana, en el caso que sea hombre, pero si es mujer se le
pagaran 2000 por semana.
-Si tiene entre 21 y 23 años se le pagaran 2300 y si es mujero seran 2100
-Si son mayores de 23 años en ambos casos se les pagaran 1000 por semana.
-Si se le pagan menos de cuatro semanas en todos los casos se les otorga un bono del 10% en caso contrario
no hay bono*/

using System;
namespace becas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa el numero de semanas a pagar: ");
            int semanas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la edad del estudiante: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el genero del estudiante (H/M): ");
            char genero = Convert.ToChar(Console.ReadLine().ToUpper());
            double pago = 0, bono = 0, total = 0;

            if (edad >= 17 && edad <= 20)
            {
                if (genero == 'H')
                {
                    pago = 1800;
                }
                else if (genero == 'M')
                {
                    pago = 2000;
                }
            }
            else if (edad >= 21 && edad <= 23)
            {
                if (genero == 'H')
                {
                    pago = 2300;
                }
                else if (genero == 'M')
                {
                    pago = 2100;
                }
            }
            else if (edad > 23)
            {
                pago = 1000;
            }
            else
            {
                Console.WriteLine("Si procede");
                pago = 1500;
            }
            if (semanas < 4)
            {
                bono = pago * 0.10;
            }
            total = (pago + bono) * semanas;
            
            Console.WriteLine("Semanas pagadas: " + semanas);
            Console.WriteLine("Pago por semana: " + pago);
            Console.WriteLine("Bono: " + bono);
            Console.WriteLine("Total a pagar: " + total);

        }
    }
}