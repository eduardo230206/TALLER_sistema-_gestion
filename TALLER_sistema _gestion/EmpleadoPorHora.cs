using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_sistema__gestion
{
        public class EmpleadoPorHora : Empleado
        {
            // Atributos privados
            private decimal sueldoPorHora;
            private int horasTrabajadas;

            // Propiedades públicas
            public decimal SueldoPorHora
            {
                get { return sueldoPorHora; }
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("El sueldo por hora debe ser mayor que cero.");

                    sueldoPorHora = value;
                }
            }

            public int HorasTrabajadas
            {
                get { return horasTrabajadas; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Las horas trabajadas no pueden ser negativas.");

                    horasTrabajadas = value;
                }
            }

            // Constructor
            public EmpleadoPorHora(string nombre, string id, decimal sueldoPorHora, int horasTrabajadas)
                : base(nombre, id)
            {
                SueldoPorHora = sueldoPorHora;
                HorasTrabajadas = horasTrabajadas;
            }

            // Implementación del método abstracto
            public override decimal CalcularSalario()
            {
                return SueldoPorHora * HorasTrabajadas;
            }

            // Sobrescribir ToString()
            public override string ToString()
            {
                return "=== EMPLEADO POR HORA ===\n" +
                       $"ID: {ID}\n" +
                       $"Nombre: {Nombre}\n" +
                       $"Sueldo por Hora: ${SueldoPorHora:F2}\n" +
                       $"Horas Trabajadas: {HorasTrabajadas}\n" +
                       $"Salario Total: ${CalcularSalario():F2}";
            }
        }
    
}

