//Fecha: 30/01/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Usa el formateo de cadenas para mostrar
una fecha en formato (dia/mes/año) */

using System;
namespace formateoFecha
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaHoraAct = DateTime.Now;
            string fechaFormateada = fechaHoraAct.ToString("dd/MM/yyyy");
            Console.WriteLine("Fecha formateada (dia/mes/año): " + fechaFormateada);

        }
    }
}