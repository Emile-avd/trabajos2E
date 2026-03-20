//Fecha: 05/02/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* calcular el descuento de la compra de una tienda bajo los siguientes parametros:
si es mayor a $1000 y menos de $3000 se da un 20% de descuento,
si se compra mas de $3000 se da un 30% de descuento y en caso contrario
no hay descuento. Mostrar el monto de la compra, el descuento y el total a pagar */

using System;
namespace tiendaDescuentos
{
    class Program
    {
        static void Main(string[] args)
        {
            double res=0, des=.0;
            Console.WriteLine("Ingresa el valor de tu compra: ");
            double num = Convert.ToInt32(Console.ReadLine());

            if (num>=1000 && num<3000)
            {   
                des=num*0.20;
            }
            else if(num>3000)
            {
                des=num*0.30;
            }
            res = num - des;
            Console.WriteLine("El monto de compra es: $"+num+", con un descuento de: $"+des+", el total a pagar es: $"+res);
        }
    }
}