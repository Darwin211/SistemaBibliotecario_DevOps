using SistemaBibliotecario.Controlador;
using SistemaBibliotecario.Entidades;
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
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            textBox1.Text = "";

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            textBox1.Focus();
        }
        public void CargarLibros()
        {
            comboBox1.DataSource = null;

            comboBox1.DataSource =
                TLibro.ListaLibros.ToList();

            comboBox1.DisplayMember = "Titulo";
        }
        public void CargarUsuarios()
        {
            comboBox2.DataSource = null;

            comboBox2.DataSource =
                TUsuario.ListaUsuarios.ToList();

            comboBox2.DisplayMember = "Nombre";
        }
        public void Mostrar()
        {

            dataGridView1.DataSource =
                TPrestamo.ListaPrestamos.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prestamo obj = new Prestamo();

            obj.IdPrestamo =
                int.Parse(textBox1.Text);

            obj.Libro =
                (Libro)comboBox1.SelectedItem;

            obj.Usuario =
                (Usuario)comboBox2.SelectedItem;

            obj.FechaPrestamo =
                dateTimePicker1.Value;

            obj.FechaDevolucion =
                dateTimePicker2.Value;

            TPrestamo.Agregar(obj);

            Mostrar();

            Limpiar();

            MessageBox.Show(
                "Préstamo registrado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos =
               TPrestamo.Buscar(
                   int.Parse(textBox1.Text));

            if (pos != -1)
            {
                Prestamo obj = new Prestamo();

                obj.IdPrestamo =
                    int.Parse(textBox1.Text);

                obj.Libro =
                    (Libro)comboBox1.SelectedItem;

                obj.Usuario =
                    (Usuario)comboBox2.SelectedItem;

                obj.FechaPrestamo =
                    dateTimePicker1.Value;

                obj.FechaDevolucion =
                    dateTimePicker2.Value;

                TPrestamo.Editar(pos, obj);

                Mostrar();

                Limpiar();

                MessageBox.Show(
                    "Préstamo editado");
            }
            else
            {
                MessageBox.Show(
                    "Préstamo no encontrado");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int pos =
               TPrestamo.Buscar(
                   int.Parse(textBox1.Text));

            if (pos != -1)
            {
                Prestamo obj =
                    TPrestamo.GetPrestamo(pos);

                textBox1.Text =
                    obj.IdPrestamo.ToString();

                comboBox1.SelectedItem =
                    obj.Libro;

                comboBox2.SelectedItem =
                    obj.Usuario;

                dateTimePicker1.Value =
                    obj.FechaPrestamo;

                dateTimePicker2.Value =
                    obj.FechaDevolucion;
            }
            else
            {
                MessageBox.Show(
                    "Préstamo no encontrado");
            }
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            CargarLibros();

            CargarUsuarios();

            Mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int pos =
                    dataGridView1.CurrentRow.Index;

                DialogResult r =
                    MessageBox.Show(
                        "¿Desea eliminar el préstamo?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    TPrestamo.Eliminar(pos);

                    Mostrar();

                    Limpiar();

                    MessageBox.Show(
                        "Préstamo eliminado");
                }
            }
            else
            {
                MessageBox.Show(
                    "Seleccione un préstamo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
