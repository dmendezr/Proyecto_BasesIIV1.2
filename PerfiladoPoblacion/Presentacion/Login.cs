using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        private string usuario;
        private int idRol;
        private string nombre;
        private string apellido1;
        private string apellido2;
        public Login()
        {
            InitializeComponent();
        }

        public Thread NuevoHilo { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable login;
            DataTable datosLogin;
            login = Logica.ConsultaLogin.obtenerLogin(txtUsuario.Text, txtContrasena.Text);
            datosLogin = Logica.ConsultaLogin.obtenerDatosLogin(txtUsuario.Text);
            if (login.Rows[0]["Condicion"].ToString() == "1")
            {
                this.usuario = datosLogin.Rows[0]["Usuario"].ToString();
                this.idRol = Convert.ToInt32(datosLogin.Rows[0]["idRol"].ToString());
                this.nombre = datosLogin.Rows[0]["nombre"].ToString();
                this.apellido1 = datosLogin.Rows[0]["apellido1"].ToString();
                this.apellido2 = datosLogin.Rows[0]["apellido2"].ToString();
                NuevoHilo = new System.Threading.Thread(new System.Threading.ThreadStart(RunPrincipal));
                this.Close();
                NuevoHilo.SetApartmentState(System.Threading.ApartmentState.STA);
                NuevoHilo.Start();
            }
            else
            {
                MessageBox.Show("Ingreso fallido, volver a intentar");
                txtContrasena.Text = "";
                txtUsuario.Text = "";
            }
            
        }

        private void RunPrincipal()
        {
            Principal frm = new Principal(usuario,idRol,nombre,apellido1,apellido2);
            frm.ShowDialog();
        }
    }
}
