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

        private string ManejarFecha()
        {
            string fecha = "";
            string dia = "";
            string mes = "";
            switch (dtpFechaCaduc.Value.Day.ToString())
            {
                case "1":
                    dia = "01";
                    break;
                case "2":
                    dia = "02";
                    break;
                case "3":
                    dia = "03";
                    break;
                case "4":
                    dia = "04";
                    break;
                case "5":
                    dia = "05";
                    break;
                case "6":
                    dia = "06";
                    break;
                case "7":
                    dia = "07";
                    break;
                case "8":
                    dia = "08";
                    break;
                case "9":
                    dia = "09";
                    break;

                default:
                    dia = dtpFechaCaduc.Value.Day.ToString();
                    break;
            }
            switch (dtpFechaCaduc.Value.Month.ToString())
            {
                case "1":
                    mes = "01";
                    break;
                case "2":
                    mes = "02";
                    break;
                case "3":
                    mes = "03";
                    break;
                case "4":
                    mes = "04";
                    break;
                case "5":
                    mes = "05";
                    break;
                case "6":
                    mes = "06";
                    break;
                case "7":
                    mes = "07";
                    break;
                case "8":
                    mes = "08";
                    break;
                case "9":
                    mes = "09";
                    break;

                default:
                    mes = dtpFechaCaduc.Value.Month.ToString();
                    break;
            }

            fecha = dtpFechaCaduc.Value.Year.ToString() + mes + dia;

            
            return fecha;

        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha;
                string sexo;
                if (cmbSexo.Text == "Masculino")
                {
                    sexo = "1";
                }
                else
                {
                    sexo = "2";
                }
                fecha = ManejarFecha();
                int consulta = Logica.MantenimientoVotante.InsertDeVotante(txtCedula.Text, cmbCodElec.Text, sexo, fecha,txtJunta.Text,txtNombre.Text,txtApellido1.Text,txtApellido2.Text);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = "";
                string sexo;
                if (cmbSexo.Text == "Masculino")
                {
                    sexo = "1";
                }
                else
                {
                    sexo = "2";
                }
                fecha = ManejarFecha();
                int consulta = Logica.MantenimientoVotante.ModificacionVotante(txtCedula.Text, cmbCodElec.Text, sexo, fecha, txtJunta.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text);
                if (consulta == 1)
                {
                    MessageBox.Show("Registro fue modificado correctamente");
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
                    MessageBox.Show("Problemas con la modificacion del nuevo registro");
                }
            }
            catch (Exception ex)
            {
                var d = new ThreadExceptionDialog(ex);
                d.ShowDialog();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
          
                int consulta = Logica.MantenimientoVotante.EliminacionVotante(txtCedula.Text);
                if (consulta == 1)
                {
                    MessageBox.Show("Registro fue eliminado correctamente");
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
                    MessageBox.Show("Problemas al eliminar el registro");
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
