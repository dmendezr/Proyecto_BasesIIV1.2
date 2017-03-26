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
        
        public PerfilacionBasica()
        {
            InitializeComponent();
        }

        public String FormarWhere()
        {
            Logica.ConstruyeWhere objConstructorWhere = new ConstruyeWhere();
            if (txtCedula.Text != "")
            {
                objConstructorWhere.filtraCedula(txtCedula.Text);
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
                dgvConsulta.DataSource = Logica.DevuelveVotante.DevuelveVotantes(SELECT, WHERE);
                
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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
