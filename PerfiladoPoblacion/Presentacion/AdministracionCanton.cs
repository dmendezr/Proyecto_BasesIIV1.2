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
    public partial class AdministracionCanton : Form
    {
        public AdministracionCanton()
        {
            InitializeComponent();
        }

        private void AdministracionCanton_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarCampos()
        {
            txtcodCanton.Text = "";
            txtNombreCanton.Text = "";

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int consulta = Logica.MantenimientoCantones.InsertDeCantones(txtcodCanton.Text,txtNombreCanton.Text);
                if (consulta == 1)
                {
                    MessageBox.Show("Registro Ingresado Correctamente");
                    LimpiarCampos();
                    txtcodCanton.Enabled = false;
                    txtNombreCanton.Enabled = false;
                 
                   // btnNuevo.Show();
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
                txtcodCanton.Enabled = true;
                txtNombreCanton.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                datos = Logica.MantenimientoCantones.BuscarCanton(txtcodCanton.Text);
                DataRow row = datos.Rows[0];
                txtNombreCanton.Text = row["nombre"].ToString();
                txtcodCanton.Text = row["codCanton"].ToString();
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
                int consulta = Logica.MantenimientoCantones.ModificarCanton(txtcodCanton.Text, txtNombreCanton.Text);
                if (consulta == 1)
                {
                    MessageBox.Show("Registro fue modificado correctamente");
                    LimpiarCampos();
                    txtcodCanton.Enabled = false;
                    txtNombreCanton.Enabled = false;
                    
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnInsertar.Show();
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
    }
}
