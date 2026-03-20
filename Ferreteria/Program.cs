//Fecha: 8/3/2026
//Autor:D.E.C
//Cuatrimestre y grupo:2E
//Version:1.0

/* Programa que oragniza el inventario de una ferreteria actuando como base de datos usando archivos de texto para almacenar la información 
   , editar, mostrar y eliminar productos. Tambiene tiene sistema de venta funcional con la base de datos*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador1
{
    class Program
    {
        static StreamReader Leer;
        static StreamWriter Escribir;
        static void Main(string[] args)
        {
            Dictionary<string, (string password, string role)> usuarios = new Dictionary<string, (string, string)>
            {
                { "admin", ("123", "Administrador") },
                { "vendedor", ("123", "Vendedor") }
            };
            int op = 0;
            do 
             {
            Console.WriteLine("----SISTEMA DE INICIO DE SESIÓN----");
            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Contraseña: ");
            string contraseña = Console.ReadLine();
            
            if (usuarios.ContainsKey(usuario) && usuarios[usuario].password == contraseña)
            {
                Console.WriteLine($"Acceso concedido. Rol: {usuarios[usuario].role}");
                
                if (usuarios[usuario].role == "Administrador")
                {
                    Console.WriteLine("Tienes acceso completo al sistema.");
                    int opcion;
                    do
                    {//banner de bienvenida
                        Console.WriteLine("---BIENVENIDO A LA FERRETERÍA---");
                        Console.WriteLine("1.-Inventario");
                        Console.WriteLine("2.-Hacer una venta");
                        Console.WriteLine("3.-Salir");
                        Console.Write("Seleccione una opción: ");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                            {
                                Program.Inventario();
                            }
                            break;
                            case 2:
                            {
                                int opcion1 = 0;
                                do
                                {//banner de bienvenida
                                    Console.WriteLine("---BIENVENIDO A LA FERRETERÍA---");
                                    opcion1 = Program.switchVenta(opcion1);
                                } while (opcion != 4);
                            }                        
                            break;
                            case 3:
                            {
                                Console.WriteLine("Saliendo del programa...");
                            }
                            break;
                            default:
                            {
                                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                            } 
                            break;
                        }
                        
                    } while (opcion != 3);
                }
                else if (usuarios[usuario].role == "Vendedor")
                {
                    Console.WriteLine("Tienes acceso limitado a ventas.");
                    int opcion = 0;
                    do
                    {//banner de bienvenida
                        Console.WriteLine("---BIENVENIDO A LA FERRETERÍA---");
                        opcion = Program.switchVenta(opcion);
                    } while (opcion != 4);
                }
            }
        else
        {
            Console.WriteLine("Usuario o contraseña incorrectos.");
        }
        Console.WriteLine("Salir del programa? (1 = Sí, 2 = No)");
        op = Convert.ToInt32(Console.ReadLine());
        if (op != 1 && op != 2)
        {
            Console.WriteLine("Opción no válida.");
        }
        } while (op != 1);
        }
        
            
        static int switchVenta (int opcion )
        {
            opcion = MostrarMenuVenta();   
            switch (opcion)
            {
                case 1:
                {
                    Program.MostrarInventario();
                    Program.Venta();       
                }                        
                break;
                case 2:
                {
                    Program.MostrarInventario();
                }
                break;
                case 3:
                {
                    Program.MostrarProducto();
                }
                break;
                case 4:
                {
                    Console.WriteLine("Saliendo del programa...");
                }
                break;
                default:
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                } 
                break;
            }
            return opcion;
        }

        static void Venta()
        {
            Console.WriteLine("****HACER UNA VENTA****");
            Console.Write("Ingresa el ID del producto a vender: ");
            int idVenta = int.Parse(Console.ReadLine());
            Console.Write("Ingresa la cantidad a vender: ");
            int cantidadVenta = int.Parse(Console.ReadLine());
            var lineas = File.ReadAllLines("archivo.txt").ToList();
            int index = lineas.FindIndex(line => line.StartsWith(idVenta.ToString() + " |"));
            if (index != -1)
            {
                var partes = lineas[index].Split('|');
                int stockActual = int.Parse(partes[2].Trim());
                decimal precioUnitario = decimal.Parse(partes[3].Trim().Replace("$", ""));
                if (cantidadVenta <= stockActual)
                {
                    stockActual -= cantidadVenta;
                    lineas[index] = $"{idVenta} | {partes[1].Trim()} | {stockActual} | ${precioUnitario}";
                    File.WriteAllLines("archivo.txt", lineas);
                    decimal totalVenta = cantidadVenta * precioUnitario;
                    DateTime ahora = DateTime.Now;
                    Console.WriteLine($"----FERRETERIA----");
                    Console.WriteLine(ahora.ToString("dd/MM/yyyy"));
                    Console.WriteLine($"Producto: {partes[1].Trim()}");
                    Console.WriteLine($"Cantidad: {cantidadVenta}");
                    Console.WriteLine($"Total: ${totalVenta}");
                }
                else
                {
                    Console.WriteLine("Stock insuficiente para realizar la venta.");
                }
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        static void Inventario()
        {
            int opcion1=0;
            do
            {
            //banner de el sistema de archivos
            Console.WriteLine("****INVENTARIO****");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Editar producto");
            Console.WriteLine("4. Mostrar inventario");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion1 = int.Parse(Console.ReadLine());

            switch (opcion1)
            {
                case 1:
                    {
                        Program.AgregarProducto();
                    }
                break;
                case 2:
                    {//elimina un elemento
                        Program.EliminarProducto(); 
                    }
                break;
                case 3:
                    {
                        Program.EditarProducto();
                    }
                break;
                case 4:
                    {
                        Program.MostrarInventario();
                    }
                break;
                case 5:
                    {
                        Console.WriteLine("Saliendo del Inventario...");
                    }
                break;
                default:
                    {
                        Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                    }    
                break;
            }
        }while(opcion1 != 5);
        }

        static void MostrarInventario()
        {
            StreamReader mostrar = new StreamReader("archivo.txt");
            Console.WriteLine(mostrar.ReadToEnd());
            mostrar.Close();
        }
        static void EditarProducto()
        {
            Console.WriteLine("Editar producto");
            Console.Write("Ingresa el ID del producto a editar: ");
            int idEditar = int.Parse(Console.ReadLine());
            var lineas = File.ReadAllLines("archivo.txt").ToList();
            int index = lineas.FindIndex(line => line.StartsWith(idEditar.ToString() + " |"));
            if (index != -1)
            {
                var partes = lineas[index].Split('|');
                Console.Write("Ingresa el nuevo nombre del producto: ");
                string nuevoNombre = Console.ReadLine();
                Console.Write("Ingresa el nuevo stock del producto: ");
                int nuevoStock = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el nuevo precio del producto: ");
                decimal nuevoPrecio = decimal.Parse(Console.ReadLine());
                lineas[index] = $"{idEditar} | {nuevoNombre} | {nuevoStock} | ${nuevoPrecio}";
                File.WriteAllLines("archivo.txt", lineas);
                Console.WriteLine("Producto editado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        static void EliminarProducto()
        {
            Console.WriteLine("Eliminar producto");
            Console.Write("Ingresa el ID del producto a eliminar: ");
            int idEliminar = int.Parse(Console.ReadLine());
            var lineas = File.ReadAllLines("archivo.txt").ToList();
            int index = lineas.FindIndex(line => line.StartsWith(idEliminar.ToString() + " |"));
            if (index != -1)
            {
                lineas.RemoveAt(index);
                File.WriteAllLines("archivo.txt", lineas);
                Console.WriteLine("Producto eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        static void AgregarProducto()
        {
            Console.WriteLine("Agregar producto");
            Console.Write("Ingresa el ID del nuevo producto: ");
            int idNuevo = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el nombre del nuevo producto: ");
            string nombreNuevo = Console.ReadLine();
            Console.Write("Ingresa el stock del nuevo producto: ");
            int stockNuevo = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el precio del nuevo producto: ");
            decimal precioNuevo = decimal.Parse(Console.ReadLine());
            string nuevaLinea = $"{idNuevo} | {nombreNuevo} | {stockNuevo} | ${precioNuevo}";
            File.AppendAllText("archivo.txt", nuevaLinea + Environment.NewLine);
            Console.WriteLine("Producto agregado exitosamente.");
        }
        static int MostrarMenuVenta()
        {
            Console.WriteLine("****HACER UNA VENTA****");
            Console.WriteLine("1. Vender producto");
            Console.WriteLine("2. Ver inventario");
            Console.WriteLine("3. Ver producto ");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
        static void MostrarProducto()
        {
            Console.WriteLine("Mostrar producto");
            Console.Write("Ingresa el ID del producto a mostrar: ");
            int idMostrar = int.Parse(Console.ReadLine());
            var lineas = File.ReadAllLines("archivo.txt").ToList();
            int index = lineas.FindIndex(line => line.StartsWith(idMostrar.ToString() + " |"));
            if (index != -1)
            {
                Console.WriteLine(lineas[index]);
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
    }
}