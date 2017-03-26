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
    public partial class AdministracionVotante : Form
    {
        public AdministracionVotante()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdministracionVotante_Load(object sender, EventArgs e)
        {
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            txtCodElec.Enabled = false;
            txtNombre.Enabled = false;
            txtFechaCaduc.Enabled = false;
            txtJunta.Enabled = false;
            txtSexo.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnNuevo.Hide();
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            txtCodElec.Enabled = true;
            txtNombre.Enabled = true;
            txtFechaCaduc.Enabled = true;
            txtJunta.Enabled = true;
            txtSexo.Enabled = true;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }
    }
}
