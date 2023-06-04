    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ClasePractica.Poco
    {
        public class Empleado
        {
            public int Id { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Cedula { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public EnumProfesion Profesion { get; set; }
            public EnumCargo Cargo { get; set; }
            public decimal Salario { get; set; }
        }
    }
