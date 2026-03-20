using System;
using System.Collections.Generic;

class Program;
namespace Name
{
    static void Main(string[] args)
    {
        Inventario inventario = new Inventario();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("=== SISTEMA FERRETERÍA ===");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Mostrar inventario");
            Console.WriteLine("3. Registrar venta");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Stock: ");
                    int stock = int.Parse(Console.ReadLine());
                    Console.Write("Precio: ");
                    decimal precio = decimal.Parse(Console.ReadLine());

                    Producto nuevo = new Producto { Id = id, Nombre = nombre, Stock = stock, Precio = precio };
                    inventario.GuardarProducto(nuevo);
                    break;

                case "2":
                    var productos = inventario.LeerProductos();
                    foreach (var p in productos)
                    {
                        Console.WriteLine($"{p.Id} - {p.Nombre} | Stock: {p.Stock} | Precio: {p.Precio:C}");
                    }
                    break;

                case "3":
                    Console.Write("ID del producto vendido: ");
                    int idVenta = int.Parse(Console.ReadLine());
                    Console.Write("Cantidad vendida: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    inventario.ActualizarStock(idVenta, cantidad);
                    break;

                case "4":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}