using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLER_sistema__gestion
{
        // Excepción personalizada
        public class EmpleadoNoEncontradoException : Exception
        {
            public EmpleadoNoEncontradoException()
                : base("El empleado no fue encontrado.")
            {
            }

            public EmpleadoNoEncontradoException(string mensaje)
                : base(mensaje)
            {
            }
        }
    }

