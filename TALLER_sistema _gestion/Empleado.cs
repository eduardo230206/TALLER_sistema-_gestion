using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_sistema__gestion
{
    
        // Clase abstracta base
        public abstract class Empleado
        {
            // Atributos privados
            private string nombre;
            private string id;

            // Propiedades públicas
            public string Nombre
            {
                get { return nombre; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El nombre no puede estar vacío.");

                    nombre = value;
                }
            }

            public string ID
            {
                get { return id; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El ID no puede estar vacío.");

                    id = value;
                }
            }

            // Constructor
            public Empleado(string nombre, string id)
            {
                Nombre = nombre;
                ID = id;
            }

            // Método abstracto
            public abstract decimal CalcularSalario();

            // Método virtual
            public override string ToString()
            {
                return $"ID: {ID}\nNombre: {Nombre}\nSalario: ${CalcularSalario():F2}";
            }
        }
}


