using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_sistema__gestion
{
        class Program
        {
            static void Main(string[] args)
            {
                Empresa empresa = new Empresa();
                bool salir = false;

                while (!salir)
                {
                    Console.Clear();
                    Console.WriteLine("=================================");
                    Console.WriteLine(" SISTEMA DE GESTIÓN DE EMPLEADOS ");
                    Console.WriteLine("=================================");
                    Console.WriteLine("1. Agregar empleado");
                    Console.WriteLine("2. Mostrar empleados");
                    Console.WriteLine("3. Buscar empleado por ID");
                    Console.WriteLine("4. Eliminar empleado");
                    Console.WriteLine("5. Salir");
                    Console.Write("Seleccione una opción: ");

                    string opcion = Console.ReadLine();

                    try
                    {
                        switch (opcion)
                        {
                            case "1":
                                AgregarEmpleado(empresa);
                                break;

                            case "2":
                                empresa.MostrarEmpleados();
                                break;

                            case "3":
                                Console.Write("Ingrese el ID del empleado: ");
                                string idBuscar = Console.ReadLine();

                                Empleado empleado = empresa.BuscarEmpleado(idBuscar);

                                Console.WriteLine("\nEmpleado encontrado:");
                                Console.WriteLine(empleado);
                                break;

                            case "4":
                                Console.Write("Ingrese el ID del empleado a eliminar: ");
                                string idEliminar = Console.ReadLine();

                                empresa.EliminarEmpleado(idEliminar);
                                break;

                            case "5":
                                salir = true;
                                Console.WriteLine("Gracias por utilizar el sistema.");
                                break;

                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    catch (EmpleadoNoEncontradoException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }

                    if (!salir)
                    {
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                    }
                }
            }

            static void AgregarEmpleado(Empresa empresa)
            {
                Console.Clear();

                Console.WriteLine("TIPO DE EMPLEADO");
                Console.WriteLine("1. Por Hora");
                Console.WriteLine("2. Asalariado");
                Console.WriteLine("3. Comisionista");
                Console.Write("Seleccione una opción: ");

                string tipo = Console.ReadLine();

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("ID: ");
                string id = Console.ReadLine();

                switch (tipo)
                {
                    case "1":
                        Console.Write("Sueldo por Hora: ");
                        decimal sueldoHora = decimal.Parse(Console.ReadLine());

                        Console.Write("Horas Trabajadas: ");
                        int horas = int.Parse(Console.ReadLine());

                        empresa.AgregarEmpleado(
                            new EmpleadoPorHora(
                                nombre,
                                id,
                                sueldoHora,
                                horas));
                        break;

                    case "2":
                        Console.Write("Sueldo Mensual: ");
                        decimal sueldoMensual = decimal.Parse(Console.ReadLine());

                        empresa.AgregarEmpleado(
                            new EmpleadoAsalariado(
                                nombre,
                                id,
                                sueldoMensual));
                        break;

                    case "3":
                        Console.Write("Sueldo Base: ");
                        decimal sueldoBase = decimal.Parse(Console.ReadLine());

                        Console.Write("Ventas Realizadas: ");
                        decimal ventas = decimal.Parse(Console.ReadLine());

                        Console.Write("Porcentaje Comisión (Ej. 0.10 = 10%): ");
                        decimal comision = decimal.Parse(Console.ReadLine());

                        empresa.AgregarEmpleado(
                            new EmpleadoComisionista(
                                nombre,
                                id,
                                sueldoBase,
                                ventas,
                                comision));
                        break;

                    default:
                        Console.WriteLine("Tipo de empleado inválido.");
                        break;
                }

                Console.WriteLine("\nEmpleado agregado correctamente.");
            }
        }
    }

