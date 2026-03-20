//Fecha: 05/02/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Se requiere calcular las pensiones donde se solicita el numero de veces a pagar y la edad del pensionado.
Si el pensionado tiene entre 50 y 65 años se le pagaran $5823 por mes, si la edad es de entre 66 y 80 años se
le pagara $8000 por mes, si es mayor de 80 se le pagara $10000 por mes mas un bono del 25%, en caso contrario
le pagaran $1500 por mes. Mostrar el numero de mese, el pago por mes, el bono y el total a pagar */

using System;
namespace pension
{
    class Program
    {
        static void Main(string[] args)
        {
            int meses, edad;
            double pago=0, bono=0, total=0;
            Console.WriteLine("Ingresa los meses pagados: ");
            meses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la edad del pensionado: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 50 && edad <= 65)
            {
                pago = 5823;
            }
            else if (edad >= 66 && edad <= 80)
            {
                pago = 8000;
            }
            else if (edad > 80)
            {
                pago = 10000;
                bono = pago * 0.25;
            }
            else
            {
                pago = 1500;
            }
            total = (pago + bono) * meses;
            Console.WriteLine("Meses pagados: " + meses);
            Console.WriteLine("Pago por mes: " + pago);
            Console.WriteLine("Bono: " + bono);
            Console.WriteLine("Total a pagar: " + total);
            
        }
    }
}