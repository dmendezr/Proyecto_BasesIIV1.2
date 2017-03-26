using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            cmbCodElec.DataSource = Logica.ConsultaCodigoElectoral.DevuelveCodElec();
            cmbCodElec.ValueMember = "CodElec";
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            cmbCodElec.Enabled = false;
            txtNombre.Enabled = false;
            dtpFechaCaduc.Enabled = false;
            txtJunta.Enabled = false;
            cmbSexo.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnBuscar.Enabled = false;
            btnNuevo.Hide();
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            cmbCodElec.Enabled = true;
            txtNombre.Enabled = true;
            dtpFechaCaduc.Enabled = true;
            txtJunta.Enabled = true;
            cmbSexo.Enabled = true;
        }

        private void LimpiarCampos()
        {
            txtCedula.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            cmbCodElec.Text = "";
            txtNombre.Text = "";
            dtpFechaCaduc.Text = "";
            txtJunta.Text = "";
            cmbSexo.Text = "";
            btnEliminar.Text = "";
            btnModificar.Text = "";

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string sexo;
                if (cmbSexo.Text == "Masculino")
                {
                    sexo = "1";
                }
                else
                {
                    sexo = "2";
                }
                int consulta = Logica.MantenimientoVotante.InsertDeVotante(txtCedula.Text, cmbCodElec.Text, sexo, dtpFechaCaduc.Text,txtJunta.Text,txtNombre.Text,txtApellido1.Text,txtApellido2.Text);
                if (consulta == 1)
                {
                    MessageBox.Show("Registro Ingresado Correctamente");
                    LimpiarCampos();
                    txtApellido1.Enabled = false;
                    txtApellido2.Enabled = false;
                    cmbCodElec.Enabled = false;
                    txtNombre.Enabled = false;
                    dtpFechaCaduc.Enabled = false;
                    txtJunta.Enabled = false;
                    cmbSexo.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnNuevo.Show();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datos = new DataTable();
                txtApellido1.Enabled = true;
                txtApellido2.Enabled = true;
                cmbCodElec.Enabled = true;
                txtNombre.Enabled = true;
                dtpFechaCaduc.Enabled = true;
                txtJunta.Enabled = true;
                cmbSexo.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                datos = Logica.DevuelveVotante.BuscarVotante(txtCedula.Text);
                DataRow row = datos.Rows[0];
                cmbCodElec.Text = row["CodElec"].ToString();
                cmbSexo.Text = row["Sexo"].ToString();
                dtpFechaCaduc.Text = row["FechaCaduc"].ToString();
                txtJunta.Text = row["Junta"].ToString();
                txtNombre.Text = row["Nombre"].ToString();
                txtApellido1.Text = row["Apellido1"].ToString();
                txtApellido2.Text = row["Apellido2"].ToString();
            }
            catch (Exception ex)
            {
                var d = new ThreadExceptionDialog(ex);
                d.ShowDialog();
            }
           
        }
    }
}
