//Fecha: 30/01/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Declara una variable del tipo DateTime
y asignale la fecha y hora actual */

using System;
namespace fechaHoraActual
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaHoraAct = DateTime.Now;
            Console.WriteLine("Fecha y hora actual: " + fechaHoraAct);
        }
    }
}