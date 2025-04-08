using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_parcial_3
{
    class Usuarios
    {
        public Usuarios() { }

        private static List<Usuarios> usuarios = new List<Usuarios>
        {
            new Usuarios {Usuario= "Wendy", Contrasenia= "12345"},
            new Usuarios {Usuario = "Ismael", Contrasenia = "54321"},

        };

        public List<Usuarios> ObtenerUsuario()
        {
            return usuarios;
        }

        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
    }
}
