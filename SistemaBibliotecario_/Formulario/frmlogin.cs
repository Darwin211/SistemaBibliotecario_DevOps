using SistemaBibliotecario.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibliotecario.Formulario
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            bool acceso = TLogin.Validar(usuario, clave);

            if (acceso)
            {
                FrmMenu menu = new FrmMenu();
                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
    
}
