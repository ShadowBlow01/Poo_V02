using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poov2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Apartamento> apartamentos = new List<Apartamento>();
            int opc = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Venta/Alquiler de Apartamentos\n\n[1] Poner en venta tu Apartamento\n[2] Poner en alquiler tu Apartamento\n[3] Ver Apartamentos en Venta/Alquiler\n[4] Salir");
                try
                {
                    opc = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Datos incorrectos...!");
                    Console.ReadKey();
                }
                Console.Clear();

                switch (opc)
                {
                    case 1:
                        Apartamento vender = new Apartamento();
                        vender.Vender();
                        apartamentos.Add(vender);
                        break;
                    case 2:
                        Apartamento alquiler = new Apartamento();
                        alquiler.Alquiler();
                        apartamentos.Add(alquiler);
                        break;
                    case 3:
                        foreach (Apartamento apt in apartamentos)
                        {
                            Console.WriteLine($"El Apartamento\n\n EL Estado: {apt.Estado} " +
                                $"\n La Direccion: {apt.Direccion} \n el Color: " +
                                $"{apt.Color} \n el Area de construccion:" +
                                $" {apt.Area} m^2" +
                                $"\nCantidad de plazas de parqueo: {apt.Parqueos} " +
                                $"\nCantidad de habitaciones:" +
                                $" {apt.Habitaciones}" +
                                $" \nCantidad de baños: {apt.Bath} " +
                                $"\nPrecio RD$ {apt.Precio} \n");
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            } while (opc != 4);
        }


        class Apartamento
        {
            public string Direccion { get; set; }
            public string Color { get; set; }
            public double Area { get; set; }
            public int Parqueos { get; set; }
            public int Habitaciones { get; set; }
            public int Bath { get; set; }
            public double Precio { get; set; }
            public string Estado { get; set; }

            public void Vender()
            {
                Console.WriteLine("Vender Apartamento\nAqui pondra a la venta su apartamento ingresando los datos del mismo \n");
                Datos();
                Estado = "En venta";
            }
            public void Alquiler()
            {
                Console.WriteLine("Poner en alquiler Apartamento\nAqui pondra en alquiler su apartamento ingresando los datos del mismo \n");
                Datos();
                Estado = "En alquiler";
            }
            private void Datos()
            {
                bool error04 = false;
                do
                {
                    try
                    {
                        Console.Write("Ingrese la direccion del apartamento[ ");
                        Direccion = Console.ReadLine();
                        Console.Write("Ingrese  Color[ ");
                        Color = Console.ReadLine();
                        Console.Write(" Ingrese Area de construccion[ ");
                        Area = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese Cantidad de plazas de parqueo[ ");
                        Parqueos = int.Parse(Console.ReadLine());
                        Console.Write(" Ingrese Cantidad de habitaciones: ");
                        Habitaciones = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese Cantidad de baños: ");
                        Bath = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese Precio RD$ ");
                        Precio = double.Parse(Console.ReadLine());
                        error04 = false;
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("DATOS INCORRECTA...");
                        Console.ReadKey();
                        Console.Clear();
                        error04 = true; 
                    }
                } while (error04 == true);
            }
        }
    }
}
