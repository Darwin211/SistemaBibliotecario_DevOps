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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FrmLibros liibros = new FrmLibros();
            liibros.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            frmPrestamo prestamo = new frmPrestamo();
            prestamo.ShowDialog();
        }
    }
}
