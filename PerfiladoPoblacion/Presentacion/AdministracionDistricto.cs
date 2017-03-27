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
    public partial class AdministracionDistricto : Form
    {
        public AdministracionDistricto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void AdministracionDistricto_Load(object sender, EventArgs e)
        {

            cmbCodCanton.DataSource = Logica.ConsultaCantones.DevuelveCanton();
            cmbCodCanton.ValueMember = "codCanton";
            cmbCodProvincia.DataSource = Logica.ConsultaProvincias.DevuelveProvincias();
            cmbCodProvincia.ValueMember = "codProvincia";

        }
        private void LimpiarCampos()
        {
            txtDistrito.Text = "";
            txtCodElec.Text = "";
            cmbCodCanton.Text = "";
            cmbCodProvincia.Text = "";
            btnEliminar.Text = "";
            btnModificar.Text = "";

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
             
                
                int consulta = Logica.MantenimientoDistrito.InsertarDistrito(txtCodElec.Text, cmbCodProvincia.Text, cmbCodCanton.Text, txtDistrito.Text);
                if (consulta == 1)
                {
                    MessageBox.Show("Registro Ingresado Correctamente");
                    LimpiarCampos();
                    txtCodElec.Enabled = false;
                    txtDistrito.Enabled = false;
                    cmbCodProvincia.Enabled = false;
                    cmbCodCanton.Enabled = false;
                    
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                  //  btnNuevo.Show();
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
                txtDistrito.Enabled = true;
                txtCodElec.Enabled = true;
                cmbCodCanton.Enabled = true;
                cmbCodProvincia.Enabled = true;
                
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                datos = Logica.MantenimientoDistrito.BuscarDistrito(txtCodElec.Text);
                DataRow row = datos.Rows[0];
                txtCodElec.Text = row["CodElec"].ToString();
                cmbCodProvincia.Text = row["codProvincia"].ToString();
                cmbCodCanton.Text = row["codCanton"].ToString();
                txtDistrito.Text = row["Distrito"].ToString();
               
            }
            catch (Exception ex)
            {
                var d = new ThreadExceptionDialog(ex);
                d.ShowDialog();
            

        }
    }
    }
}
