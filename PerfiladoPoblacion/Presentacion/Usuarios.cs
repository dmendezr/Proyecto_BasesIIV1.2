using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            txtIdUsuario.Text ="";
            txtCedula.Text = "";
            txtIdRol.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                int consulta = Logica.MantenimientoUsuario.InsertarUsuario(txtIdUsuario.Text, txtCedula.Text,txtIdRol.Text,txtUsuario.Text,txtContraseña.Text);
                if (consulta == 1)
                {
                    MessageBox.Show("Registro Ingresado Correctamente");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Problemas con la insercion del nuevo registro");
                }
            }
            catch (Exception ex)
            {
                var d = new ThreadExceptionDialog(ex);
                d.ShowDialog();
            }
        }
    }
}
