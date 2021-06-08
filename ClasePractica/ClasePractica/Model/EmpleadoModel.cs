using ClasePractica.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica.Model
{
    public class EmpleadoModel
    {
        private Empleado[] empleados;
        public EmpleadoModel() { }

        public void AddElements(Empleado empleado) {
            if ( empleados == null)
            {
                empleados = new Empleado[1];
                empleados[0] = empleado;
                return;
            }
            Empleado[] temporal = new Empleado[empleados.Length +1];
            Array.Copy(empleados, temporal, empleados.Length);
            temporal[temporal.Length - 1] = empleado;
            empleados = temporal;
        }

        public void Remove(int index) {
            if (index < 0)
            {
                return;
            }

            if (empleados == null)
            {
                return;
            }

            if (index >= empleados.Length)
            {
                throw new IndexOutOfRangeException($"El index {index} está fuera de rango");
            }

            if (index == 0 && empleados.Length == 1)
            {
                empleados = null;
                return;
            }

            Empleado[] temporal = new Empleado[empleados.Length - 1];

            if (index == 0)
            {
                Array.Copy(empleados, index+1, temporal, 0, temporal.Length);
                empleados = temporal;
                return;
            }

            if (index == empleados.Length-1)
            {
                Array.Copy(empleados, 0, temporal, 0, temporal.Length);
                empleados = temporal;
                return;
            }

            if (index == 0)
            {
                Array.Copy(empleados, index + 1, temporal, 0, temporal.Length);
                empleados = temporal;
                return;
            }

            Array.Copy(empleados, 0, temporal, 0, index);
            Array.Copy(empleados, index+1, temporal, index, (temporal.Length-index));
            empleados = temporal;
        }
        public Empleado[] GetAll() {
            return empleados;
        }
    }
}
