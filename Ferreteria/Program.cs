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

        // ===== FUNCIONES AUXILIARES PARA PRESENTACIÓN =====
        static void MostrarTitulo(string titulo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║ {titulo.PadRight(62)} ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝\n");
            Console.ResetColor();
        }

        static void MostrarExito(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"✓ {mensaje}");
            Console.ResetColor();
        }

        static void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"✗ {mensaje}");
            Console.ResetColor();
        }

        static void MostrarAdvertencia(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"⚠ {mensaje}");
            Console.ResetColor();
        }

        static void MostrarInfo(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"ℹ {mensaje}");
            Console.ResetColor();
        }

        static void MostrarLinea()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("─────────────────────────────────────────────────────────────────");
            Console.ResetColor();
        }

        static void MostrarOpcion(int numero, string descripcion)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{numero}. ");
            Console.ResetColor();
            Console.WriteLine(descripcion);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, (string password, string role)> usuarios = new Dictionary<string, (string, string)>
            {
                { "admin", ("123", "Administrador") },
                { "vendedor", ("123", "Vendedor") }
            };
            int op = 0;
            do 
             {
            Console.Clear();
            MostrarTitulo("🔐 SISTEMA DE INICIO DE SESIÓN");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Usuario: ");
            Console.ResetColor();
            string usuario = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Contraseña: ");
            Console.ResetColor();
            string contraseña = Console.ReadLine();
            
            if (usuarios.ContainsKey(usuario) && usuarios[usuario].password == contraseña)
            {
                MostrarExito($"¡Acceso concedido! Rol: {usuarios[usuario].role}");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                
                if (usuarios[usuario].role == "Administrador")
                {
                    MostrarExito("Tienes acceso completo al sistema.");
                    int opcion;
                    do
                    {
                        Console.Clear();
                        MostrarTitulo("🏪 BIENVENIDO A LA FERRETERÍA - ADMINISTRADOR");
                        MostrarOpcion(1, "Gestionar Inventario");
                        MostrarOpcion(2, "Realizar una Venta");
                        MostrarOpcion(3, "Salir del Programa");
                        MostrarLinea();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Seleccione una opción: ");
                        Console.ResetColor();
                        opcion = Convert.ToInt32(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                            {
                                Console.Clear();
                                Program.Inventario();
                            }
                            break;
                            case 2:
                            {
                                int opcion1 = 0;
                                do
                                {
                                    Console.Clear();
                                    opcion1 = Program.switchVenta(opcion1);
                                } while (opcion1 != 4);
                            }                        
                            break;
                            case 3:
                            {
                                MostrarExito("Saliendo del programa...");
                            }
                            break;
                            default:
                            {
                                MostrarError("Opción no válida. Por favor, seleccione una opción válida.");
                                System.Threading.Thread.Sleep(1500);
                            } 
                            break;
                        }
                        
                    } while (opcion != 3);
                }
                else if (usuarios[usuario].role == "Vendedor")
                {
                    MostrarInfo("Tienes acceso limitado a ventas.");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    int opcion = 0;
                    do
                    {
                        Console.Clear();
                        MostrarTitulo("🏪 BIENVENIDO A LA FERRETERÍA - VENDEDOR");
                        opcion = Program.switchVenta(opcion);
                    } while (opcion != 4);
                }
            }
        else
        {
            MostrarError("Usuario o contraseña incorrectos.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
        MostrarAdvertencia("¿Salir del programa? (1 = Sí, 2 = No):");
        op = Convert.ToInt32(Console.ReadLine());
        if (op != 1 && op != 2)
        {
            MostrarError("Opción no válida.");
        }
        } while (op != 1);
        }
        
            
        static int switchVenta (int opcion )
        {
            opcion = MostrarMenuVenta();
            do
            {
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
            }while (opcion != 4);
            
        }

        static void Venta()
        {
            MostrarTitulo("💳 REALIZAR UNA VENTA");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ID del producto a vender: ");
            Console.ResetColor();
            int idVenta = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Cantidad a vender: ");
            Console.ResetColor();
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
                    lineas[index] = $"{idVenta.ToString().PadRight(5)} | {partes[1].Trim().PadRight(25)} | {stockActual.ToString().PadRight(8)} | ${precioUnitario.ToString().PadRight(10)}";
                    File.WriteAllLines("archivo.txt", lineas);
                    decimal totalVenta = cantidadVenta * precioUnitario;
                    DateTime ahora = DateTime.Now;
                    
                    Console.Clear();
                    MostrarTitulo("🧾 COMPROBANTE DE VENTA");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Fecha: {ahora.ToString("dd/MM/yyyy HH:mm:ss")}");
                    Console.WriteLine(new string('─', 65));
                    Console.ResetColor();
                    Console.WriteLine($"Producto: {partes[1].Trim()}");
                    Console.WriteLine($"Cantidad: {cantidadVenta} unidad(es)");
                    Console.WriteLine($"Precio unitario: ${precioUnitario:F2}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string('═', 65));
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"TOTAL: ${totalVenta:F2}");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string('═', 65));
                    Console.ResetColor();
                    MostrarExito("¡Venta realizada exitosamente!");
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {
                    MostrarError("Stock insuficiente para realizar la venta.");
                    System.Threading.Thread.Sleep(1500);
                }
            }
            else
            {
                MostrarError("Producto no encontrado.");
                System.Threading.Thread.Sleep(1500);
            }
        }

        static void Inventario()
        {
            int opcion1=0;
            do
            {
                Console.Clear();
                MostrarTitulo("📦 GESTIÓN DE INVENTARIO");
                MostrarOpcion(1, "Agregar nuevo Producto");
                MostrarOpcion(2, "Eliminar Producto");
                MostrarOpcion(3, "Editar Producto");
                MostrarOpcion(4, "Mostrar Inventario");
                MostrarOpcion(5, "Salir");
                MostrarLinea();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Seleccione una opción: ");
                Console.ResetColor();
                opcion1 = int.Parse(Console.ReadLine());

                switch (opcion1)
                {
                    case 1:
                        {
                            Console.Clear();
                            Program.AgregarProducto();
                        }
                    break;
                    case 2:
                        {
                            Console.Clear();
                            Program.EliminarProducto(); 
                        }
                    break;
                    case 3:
                        {
                            Console.Clear();
                            Program.EditarProducto();
                        }
                    break;
                    case 4:
                        {
                            Console.Clear();
                            Program.MostrarInventario();
                            MostrarLinea();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Presione ENTER para continuar...");
                            Console.ResetColor();
                            Console.ReadLine();
                        }
                    break;
                    case 5:
                        {
                            MostrarExito("Saliendo del Inventario...");
                            System.Threading.Thread.Sleep(1000);
                        }
                    break;
                    default:
                        {
                            MostrarError("Opción no válida, por favor intente de nuevo.");
                            System.Threading.Thread.Sleep(1500);
                        }    
                    break;
                }
            }while(opcion1 != 5);
        }

        static void MostrarInventario()
        {
            MostrarTitulo("📋 LISTADO DE INVENTARIO");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ID    | Nombre                    | Stock    | Precio    ");
            Console.WriteLine("-----|---------------------------|----------|--------- ");
            Console.ResetColor();
            StreamReader mostrar = new StreamReader("archivo.txt");
            string contenido = mostrar.ReadToEnd();
            if (string.IsNullOrEmpty(contenido))
            {
                MostrarAdvertencia("El inventario está vacío.");
            }
            else
            {
                Console.WriteLine(contenido);
            }
            mostrar.Close();
        }
        static void EditarProducto()
        {
            MostrarTitulo("✏️  EDITAR PRODUCTO");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ID del producto a editar: ");
            Console.ResetColor();
            int idEditar = int.Parse(Console.ReadLine());
            var lineas = File.ReadAllLines("archivo.txt").ToList();
            int index = lineas.FindIndex(line => line.StartsWith(idEditar.ToString() + " |"));
            if (index != -1)
            {
                var partes = lineas[index].Split('|');
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Nuevo nombre del producto: ");
                Console.ResetColor();
                string nuevoNombre = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Nuevo stock del producto: ");
                Console.ResetColor();
                int nuevoStock = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Nuevo precio del producto: ");
                Console.ResetColor();
                decimal nuevoPrecio = decimal.Parse(Console.ReadLine());
                lineas[index] = $"{idEditar.ToString().PadRight(5)} | {nuevoNombre.PadRight(25)} | {nuevoStock.ToString().PadRight(8)} | ${nuevoPrecio.ToString().PadRight(10)}";
                File.WriteAllLines("archivo.txt", lineas);
                MostrarExito("¡Producto editado exitosamente!");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
            }
            else
            {
                MostrarError("Producto no encontrado.");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
            }
        }
        static void EliminarProducto()
        {
            MostrarTitulo("🗑️  ELIMINAR PRODUCTO");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ID del producto a eliminar: ");
            Console.ResetColor();
            int idEliminar = int.Parse(Console.ReadLine());
            var lineas = File.ReadAllLines("archivo.txt").ToList();
            int index = lineas.FindIndex(line => line.StartsWith(idEliminar.ToString() + " |"));
            if (index != -1)
            {
                lineas.RemoveAt(index);
                File.WriteAllLines("archivo.txt", lineas);
                MostrarExito("¡Producto eliminado exitosamente!");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
            }
            else
            {
                MostrarError("Producto no encontrado.");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
            }
        }
        static void AgregarProducto()
        {
            MostrarTitulo("➕ AGREGAR NUEVO PRODUCTO");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ID del producto: ");
            Console.ResetColor();
            int idNuevo = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Nombre del producto: ");
            Console.ResetColor();
            string nombreNuevo = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Stock del producto: ");
            Console.ResetColor();
            int stockNuevo = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Precio del producto: ");
            Console.ResetColor();
            decimal precioNuevo = decimal.Parse(Console.ReadLine());
            string nuevaLinea = $"{idNuevo.ToString().PadRight(5)} | {nombreNuevo.PadRight(25)} | {stockNuevo.ToString().PadRight(8)} | ${precioNuevo.ToString().PadRight(10)}";
            File.AppendAllText("archivo.txt", nuevaLinea + Environment.NewLine);
            MostrarExito("¡Producto agregado exitosamente!");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
        }
        static int MostrarMenuVenta()
        {
            Console.Clear();
            MostrarTitulo("💳 SISTEMA DE VENTAS");
            MostrarOpcion(1, "Vender Producto");
            MostrarOpcion(2, "Ver Inventario");
            MostrarOpcion(3, "Ver Información de Producto");
            MostrarOpcion(4, "Salir");
            MostrarLinea();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Seleccione una opción: ");
            Console.ResetColor();
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
        static void MostrarProducto()
        {
            MostrarTitulo("🔍 VER INFORMACIÓN DE PRODUCTO");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ID del producto: ");
            Console.ResetColor();
            int idMostrar = int.Parse(Console.ReadLine());
            var lineas = File.ReadAllLines("archivo.txt").ToList();
            int index = lineas.FindIndex(line => line.StartsWith(idMostrar.ToString() + " |"));
            if (index != -1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ID    | Nombre                    | Stock    | Precio    ");
                Console.WriteLine("-----|---------------------------|----------|--------- ");
                Console.ResetColor();
                Console.WriteLine(lineas[index]);
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                MostrarError("Producto no encontrado.");
                System.Threading.Thread.Sleep(1500);
            }
        }
    }
}