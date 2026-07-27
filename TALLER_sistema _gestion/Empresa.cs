using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_sistema__gestion
{
        public class Empresa
        {
            // Lista donde se almacenan todos los empleados
            private List<Empleado> empleados;

            // Constructor
            public Empresa()
            {
                empleados = new List<Empleado>();
            }

            // Agregar empleado
            public void AgregarEmpleado(Empleado empleado)
            {
                if (ExisteID(empleado.ID))
                {
                    throw new ArgumentException("Ya existe un empleado con ese ID.");
                }

                empleados.Add(empleado);
            }

            // Mostrar todos los empleados
            public void MostrarEmpleados()
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine("\nNo hay empleados registrados.\n");
                    return;
                }

                Console.WriteLine("\n===== LISTA DE EMPLEADOS =====\n");

                foreach (Empleado empleado in empleados)
                {
                    Console.WriteLine(empleado);
                    Console.WriteLine("--------------------------------");
                }
            }

            // Buscar empleado por ID
            public Empleado BuscarEmpleado(string id)
            {
                foreach (Empleado empleado in empleados)
                {
                    if (empleado.ID.Equals(id, StringComparison.OrdinalIgnoreCase))
                    {
                        return empleado;
                    }
                }

                throw new EmpleadoNoEncontradoException(
                    $"No existe un empleado con ID: {id}");
            }

            // Eliminar empleado por ID
            public void EliminarEmpleado(string id)
            {
                Empleado empleado = BuscarEmpleado(id);

                empleados.Remove(empleado);

                Console.WriteLine("Empleado eliminado correctamente.");
            }

            // Verificar si el ID ya existe
            public bool ExisteID(string id)
            {
                foreach (Empleado empleado in empleados)
                {
                    if (empleado.ID.Equals(id, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }

                return false;
            }

            // Obtener la lista de empleados
            public List<Empleado> ObtenerEmpleados()
            {
                return empleados;
            }
        }
    }

