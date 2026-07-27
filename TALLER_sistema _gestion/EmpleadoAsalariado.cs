using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_sistema__gestion
{
        public class EmpleadoAsalariado : Empleado
        {
            // Atributo privado
            private decimal sueldoMensual;

            // Propiedad pública
            public decimal SueldoMensual
            {
                get { return sueldoMensual; }
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("El sueldo mensual debe ser mayor que cero.");

                    sueldoMensual = value;
                }
            }

            // Constructor
            public EmpleadoAsalariado(string nombre, string id, decimal sueldoMensual)
                : base(nombre, id)
            {
                SueldoMensual = sueldoMensual;
            }

            // Implementación del método abstracto
            public override decimal CalcularSalario()
            {
                return SueldoMensual;
            }

            // Sobrescribe el método ToString()
            public override string ToString()
            {
                return "=== EMPLEADO ASALARIADO ===\n" +
                       $"ID: {ID}\n" +
                       $"Nombre: {Nombre}\n" +
                       $"Sueldo Mensual: ${SueldoMensual:F2}\n" +
                       $"Salario Total: ${CalcularSalario():F2}";
            }
        }
    
}
