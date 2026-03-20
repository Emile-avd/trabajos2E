//Fecha: 12/2/2026
//Autor: D.E.C
//Cuatrimestre y grupo: 2E
//versión: 1

/* Realizar un for para calcular el area o volumen de figuras geometricas haciendo las operaciones en funciones
para despues llamarlas al codigo principal */
using System;
using System.Data;
using System.Runtime.InteropServices;
namespace FuncionesFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            int op1 = 0;
            do
            {
                Console.WriteLine("OPERACIONES GEOMETRICAS");
                Console.WriteLine("Elige tu figura: ");
                Console.WriteLine("1.Cubo");
                Console.WriteLine("2.Paralelepido");
                Console.WriteLine("3.Piramide");
                Console.WriteLine("4.Cilindro");
                Console.WriteLine("5.Cono");
                Console.WriteLine("6.Esfera");
                Console.WriteLine("7.Salir");
                op1 = Convert.ToInt32(Console.ReadLine());
                switch(op1)
                {
                    case 1:
                        {
                            Program.Cubo();
                        }
                    break;
                    case 2:
                        {
                            Program.Paralelepido();
                        }
                    break;
                    case 3:
                        {
                            Program.Piramide();
                        }
                    break;
                    case 4:
                        {
                            Program.Cilindro();
                        }
                    break;
                    case 5:
                        {
                            Program.Cono();
                        }
                    break;
                    case 6:
                        {
                            Program.Esfera();
                        }
                    break;   
                    case 7:
                        {
                            Console.WriteLine("Gracias por su visita");
                        }       
                    break;          
                    default:
                        {
                            Console.WriteLine("Opcion invalida :(");
                        }
                    break;
                }

            }while(op1 != 7);
        }

        static void Cubo()
        {
            double A=0,l=0,V=0;
            Console.WriteLine("Elige una operacion:");
            Console.WriteLine("1.-Area");
            Console.WriteLine("2.-Volumen");
            int op = Convert.ToInt32(Console.ReadLine());
            if(op == 1)
            {
                Console.WriteLine("Ingresa el lado:");
                l = Convert.ToDouble(Console.ReadLine());
                A = 6*(l*l);
                Console.WriteLine("El area es: "+A);
            } else if (op == 2)
            {
                Console.WriteLine("Ingresa el lado:");
                l = Convert.ToDouble(Console.ReadLine());
                V = l*l*l;
                Console.WriteLine("El volumen es: "+V);
            }
            else
            {
                Console.WriteLine("Opcion invalida");
            }
        }

        static void Paralelepido()
        {
            double R=0;
            double La=0,An=0,Al=0;
            Console.WriteLine("Elige una operacion:");
            Console.WriteLine("1.-Area");
            Console.WriteLine("2.-Volumen");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Largo:");
            La = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ancho:");
            An = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Altura:");
            Al = Convert.ToDouble(Console.ReadLine());
            if(op == 1)
            {
                R=2*(La*An + La*Al + An*Al);
                Console.WriteLine("El area es de:"+R);
            } else if(op == 2)
            {
                R=La*An*Al;
                Console.WriteLine("El volumen es: "+R);
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }

        static void Piramide()
        {
            int op=0;
            Console.WriteLine("Elige una operacion:");
            Console.WriteLine("1.-Area");
            Console.WriteLine("2.-Volumen");
            op = Convert.ToInt32(Console.ReadLine());
            if (op==1)
            {
                Console.WriteLine("Ingresa el lado");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el total de lados de la base:");
                double Tl = Convert.ToDouble(Console.ReadLine());
                double R = l * Tl ;
                Console.WriteLine("Ingresa la apotema:");
                double apo = Convert.ToDouble(Console.ReadLine());
                double Ap = R * apo;
                Console.WriteLine("Ingresa el valor de la base del triangulo:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa la altura del triangulo:");
                double h = Convert.ToDouble(Console.ReadLine());
                double At = (b * h) / 2;
                double A = At + Ap;
                Console.WriteLine("El area es: "+A);
                


            } else if (op == 2)
            {
                Console.WriteLine("Ingresa la altura de la piramide:");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el lado");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el total de lados de la base:");
                double Tl = Convert.ToDouble(Console.ReadLine());
                double R = l * Tl ;
                Console.WriteLine("Ingresa la apotema:");
                double apo = Convert.ToDouble(Console.ReadLine());
                double Ap = R * apo;
                double V = (Ap * h) / 3;
                Console.WriteLine("El volumen es: "+V);
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }

        static void Cilindro()
        {
            Console.WriteLine("Elige una operacion:");
            Console.WriteLine("1.-Area");
            Console.WriteLine("2.-Volumen");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el radio:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la altura:");
            double h = Convert.ToDouble(Console.ReadLine());
            
            if (op == 1)
            {
                double R = 2 * Math.PI * r * (r + h);
                Console.WriteLine("El area es: "+R);
            } else if (op == 2)
            {
                double V = Math.PI * r * r * h;
                Console.WriteLine("El volumen es: "+V);
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }

        static void Cono()
        {
                Console.WriteLine("Elige una operacion:");
            Console.WriteLine("1.-Area");
            Console.WriteLine("2.-Volumen");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op==1)
            {
                Console.WriteLine("Ingresa el radio:");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa la altura:");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa la generatriz:");
                double g = Convert.ToDouble(Console.ReadLine());
                double A = Math.PI * r * (r + g);
                Console.WriteLine("El area es: "+A);
            } else if (op == 2)
            {
                Console.WriteLine("Ingresa el radio:");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa la altura:");
                double h = Convert.ToDouble(Console.ReadLine());
                double V = (Math.PI * r * r * h) / 3;
                Console.WriteLine("El volumen es: "+V);
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }

        static void Esfera()
        {
            Console.WriteLine("Elige una operacion:");
            Console.WriteLine("1.-Area");
            Console.WriteLine("2.-Volumen");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el radio:");
            double r = Convert.ToDouble(Console.ReadLine());
            if (op == 1)
            {
                double A = 4 * Math.PI * r * r;
                Console.WriteLine("El area es: "+A);
            } else if (op == 2)
            {
                double V = (4.0/3.0) * Math.PI * r * r * r;
                Console.WriteLine("El volumen es: "+V);
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }
    }
}