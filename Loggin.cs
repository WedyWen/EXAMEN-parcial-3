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
    public partial class Loggin : Form
    {
        Usuarios usuarios = new Usuarios();
        public Loggin()
        {
            InitializeComponent();
        }

        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
            string user = txbUSUARIO.Text;
            string password =txbCONTRASENIA.Text;

            var lista = usuarios.ObtenerUsuario();
            var validar = lista.FirstOrDefault(u => u.Usuario == user && u.Contrasenia == password);
            if (validar != null)
            {
                this.Hide();
                INICIO inicio = new INICIO();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("ERROR");
            }




        }
    }
}
