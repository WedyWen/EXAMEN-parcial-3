using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_parcial_3
{
    internal class Acciones
    {
        public Acciones() { }

        caracteristica c = new caracteristica();
        List<caracteristica> Listaproducto = new List<caracteristica>
        {
            new caracteristica("Morado",1234,"MarioBros",DateTime.Today,true),
            new caracteristica("Azul Claro",54321,"TLOU",DateTime.Today,true),
        };
        public List<caracteristica> mostrar()
        {
            return Listaproducto;
        }
        public bool EliminarP(int ID)
        {
            try
            {
                var objetoEliminar = Listaproducto.Find(x => x.ID == ID);
                if (objetoEliminar != null)
                {
                    Listaproducto.Remove(objetoEliminar);
                    return true;
                }
                return false;
            }
            catch { return false; }
        }

        public bool Insertar(string colorInterfaz, int iD, string nombre, DateTime fechaRegistro, bool activo)
        {
            try
            {
                Listaproducto.Add(new caracteristica(c.colorInterfaz = colorInterfaz, c.ID = iD, c.Nombre = nombre, c.FechaRegistro = fechaRegistro, c.Activo = activo));
                return true;

            }
            catch (Exception)

            { return false; }
        }

        public bool actualizar(string colorInterfaz, int iD, string nombre, DateTime fechaRegistro, bool activo)
        {
            try
            {
                var objetoActualizar = Listaproducto.Find(x => x.ID == iD);
                if (objetoActualizar != null)
                {
                    objetoActualizar.colorInterfaz = colorInterfaz;
                    objetoActualizar.ID = iD;
                    objetoActualizar.Nombre = nombre;
                    objetoActualizar.FechaRegistro = fechaRegistro;
                    objetoActualizar.Activo = activo;
                    return true;
                }
                return true;
            }
            catch { return false; }
        }
    }
}
