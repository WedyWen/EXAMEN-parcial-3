using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_parcial_3
{
    internal class Consola
    {
        public Consola() { }

        public Consola(int iD, string nombre, DateTime fechaRegistro, bool activo)
        {
            ID = iD;
            this.Nombre = nombre;
            FechaRegistro = fechaRegistro;
            this.Activo = activo;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
    }
}
