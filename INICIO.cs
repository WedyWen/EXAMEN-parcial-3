using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_parcial_3
{
    public partial class INICIO : Form
    {
        Acciones
        public INICIO()
        {
            InitializeComponent();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {

        }

        private void INICIO_Load_1(object sender, EventArgs e)
        {

        }

        private void btnMOSTRAR_Click(object sender, EventArgs e)
        {
            DGdatos.DataSource = null;
            DGdatos.DataSource = Acciones.mostrar();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (Acciones.EliminarP(Convert.ToInt32(tbxEliminar.Text)))
                MessageBox.Show("Se elimino con exito");
            else
                MessageBox.Show("ERROR");
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (Acciones.Insertar(tbxColor.Text, Convert.ToInt32(tbxID.Text), tbxNombre.Text, Convert.ToDateTime(tbxFecha.Text), Convert.ToBoolean(tbxActivo.Text)))
                MessageBox.Show("Agregado con exito");
            else
                MessageBox.Show("Fallo");
        }

        private void btnACTUALIZAR_Click(object sender, EventArgs e)
        {
            if (Acciones.actualizar(tbxColor.Text, Convert.ToInt32(tbxID.Text), tbxNombre.Text, Convert.ToDateTime(tbxFecha.Text), Convert.ToBoolean(tbxActivo.Text)))
                MessageBox.Show("Actualizado con exito");
            else
                MessageBox.Show("Fallo");
        }

        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
