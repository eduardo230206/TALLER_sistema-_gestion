using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_sistema__gestion
{
        public class EmpleadoComisionista : Empleado
        {
            // Atributos privados
            private decimal sueldoBase;
            private decimal ventasRealizadas;
            private decimal porcentajeComision;

            // Propiedades públicas
            public decimal SueldoBase
            {
                get { return sueldoBase; }
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("El sueldo base debe ser mayor que cero.");

                    sueldoBase = value;
                }
            }

            public decimal VentasRealizadas
            {
                get { return ventasRealizadas; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Las ventas realizadas no pueden ser negativas.");

                    ventasRealizadas = value;
                }
            }

            public decimal PorcentajeComision
            {
                get { return porcentajeComision; }
                set
                {
                    if (value < 0 || value > 1)
                        throw new ArgumentException("El porcentaje de comisión debe estar entre 0 y 1.");

                    porcentajeComision = value;
                }
            }

            // Constructor
            public EmpleadoComisionista(
                string nombre,
                string id,
                decimal sueldoBase,
                decimal ventasRealizadas,
                decimal porcentajeComision)
                : base(nombre, id)
            {
                SueldoBase = sueldoBase;
                VentasRealizadas = ventasRealizadas;
                PorcentajeComision = porcentajeComision;
            }

            // Implementación del método abstracto
            public override decimal CalcularSalario()
            {
                return SueldoBase + (VentasRealizadas * PorcentajeComision);
            }

            // Sobrescribir ToString()
            public override string ToString()
            {
                return "=== EMPLEADO COMISIONISTA ===\n" +
                       $"ID: {ID}\n" +
                       $"Nombre: {Nombre}\n" +
                       $"Sueldo Base: ${SueldoBase:F2}\n" +
                       $"Ventas Realizadas: ${VentasRealizadas:F2}\n" +
                       $"Porcentaje Comisión: {PorcentajeComision:P}\n" +
                       $"Salario Total: ${CalcularSalario():F2}";
            }
        }
    }

