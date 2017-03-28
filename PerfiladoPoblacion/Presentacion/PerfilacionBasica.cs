using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace Presentacion
{
    public partial class PerfilacionBasica : Form
    {
        public string usuario;
        
        public PerfilacionBasica(string user)
        {
            this.usuario = user;
            InitializeComponent();
        }

        public void limpiarCampos()
        {
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtCedula.Text = "";
            txtCodElec.Text = "";
            txtEdad.Text = "";
            txtFechaCaduc.Text = "";
            txtJunta.Text = "";
            txtNombre.Text = "";
            cbCanton.Text = "";
            cbDistrito.Text = "";
            cbProvincia.Text = "";
            cbDistrito.Text = "";
            cbSexo.Text = "";
        }

        public String FormarWhere()
        {
            Logica.ConstruyeWhere objConstructorWhere = new ConstruyeWhere();
            if (txtCedula.Text != "")
            {
                objConstructorWhere.filtraCedula(txtCedula.Text);
            }
            if (txtNombre.Text != "")
            {
                objConstructorWhere.filtrarNombre(txtNombre.Text);
            }
            if(txtApellido1.Text != "")
            {
                objConstructorWhere.filtrarApellido1(txtApellido1.Text);
            }
            if (txtApellido2.Text != ""){
                objConstructorWhere.filtrarApellido2(txtApellido2.Text);
            }
            if (txtJunta.Text != "")
            {
                objConstructorWhere.filtrarJunta(txtJunta.Text);
            }
            if (txtFechaCaduc.Text != "")
            {
                objConstructorWhere.filtrarFechaCaduc(txtFechaCaduc.Text);
            }
            if (cbSexo.Text != "")
            {
                objConstructorWhere.filtrarSexo(txtFechaCaduc.Text);
            }
            if (cbCanton.Text != "")
            {
                objConstructorWhere.filtrarSexo(cbCanton.Text);
            }
            if (cbDistrito.Text != "")
            {
                objConstructorWhere.filtrarDistrito(cbDistrito.Text);
            }
            if (cbProvincia.Text != "")
            {
                objConstructorWhere.filtrarProvincia(cbProvincia.Text);
            }

            return objConstructorWhere.devuelveCadena();

        }
        public String FormarCadena()
        {
            Logica.ConstruyeSelect objCadena = new Logica.ConstruyeSelect();
            if (chbCedula.Checked)
            {
                objCadena.devuelveCedula();
            }
            if (chbCodElec.Checked)
            {
                objCadena.devuelveCodElec();
            }
            if (chbSexo.Checked)
            {
                objCadena.devuelveSexo();
            }
            if (chbFechaCaduc.Checked)
            {
                objCadena.devuelveFechaCaduc();
            }
            if (chbJunta.Checked)
            {
                objCadena.devuelveJunta();
            }
            if (chbNombre.Checked)
            {
                objCadena.devuelveNombre();
            }
            if (chbApellido1.Checked)
            {
                objCadena.devuelvePrimerApellido();
            }
            if (chbApellido2.Checked)
            {
                objCadena.devuelveSegundoApellido();
            }
            /*if (chbEdad.Checked)
            {
                
            }*/
            if (chbDistrito.Checked)
            {
                objCadena.devuelveDistrito();
            }
            if (chbCanton.Checked)
            {
                objCadena.devuelveCanton();
            }
            if (chbProvincia.Checked) {
                objCadena.devuelveProvincia();
            }

            return objCadena.devuelveCadena();
            
        }

        private void chbSexo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                String SELECT = FormarCadena();
                String WHERE = FormarWhere();
                //dgvConsulta.DataSource = Logica.DevuelveVotante.DevuelveVotantes(SELECT, WHERE,usuario);
                ReporteDatos frmReporte = new ReporteDatos(Logica.DevuelveVotante.DevuelveVotantes(SELECT, WHERE, usuario));
                frmReporte.ShowDialog();
                limpiarCampos();
                
            }catch (Exception ex)
            {
                var d = new ThreadExceptionDialog(ex);
                d.ShowDialog();
            }
            
        }

        private void PerfilacionBasica_Load(object sender, EventArgs e)
        {
            cbProvincia.DataSource = Logica.ConsultaProvincias.DevuelveProvincias();
            cbProvincia.ValueMember = "Nombre";
            cbCanton.DataSource = Logica.ConsultaCantones.DevuelveCanton();
            cbCanton.ValueMember = "Nombre";
            cbDistrito.DataSource = Logica.ConsultaDistrito.devuelveDistrito();
            cbDistrito.ValueMember = "Distrito";
            limpiarCampos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }


        private void cbDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
