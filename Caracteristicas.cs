using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_parcial_3
{
    internal class Caracteristicas
    {
        public caracteristica() { }
        public caracteristica(string colorInterfaz, int iD, string nombre, DateTime fechaRegistro, bool activo)
            : base(iD, nombre, fechaRegistro, activo)
        {
            this.colorInterfaz = colorInterfaz;
        }

        public string colorInterfaz { get; set; }

    }
}
