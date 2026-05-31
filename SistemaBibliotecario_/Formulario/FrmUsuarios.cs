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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        public void Datos()
        {
            TUsuario.ListaUsuarios.Add(new Usuario
            {
                IdUsuario = 1,
                Nombre = "Juan Pérez",
                Cedula = "1234567890",
                Correo = "juan.perez@example.com",
                Telefono = "555-1234"
            });
            TUsuario.ListaUsuarios.Add(new Usuario
            {
                IdUsuario = 2,
                Nombre = "María Gómez",
                Cedula = "0987654321",
                Correo = "maria.gomez@example.com",
                Telefono = "555-5678"
            });
        }
        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            textBox1.Focus();
        }

        public void Mostrar()
        {

            dataGridView1.DataSource =
                TUsuario.ListaUsuarios.ToList();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Datos();
            Mostrar();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();

            obj.IdUsuario =
                int.Parse(textBox1.Text);

            obj.Nombre =
                textBox2.Text;

            obj.Cedula =
                textBox3.Text;

            obj.Correo =
                textBox4.Text;

            obj.Telefono =
                textBox5.Text;

            TUsuario.Agregar(obj);

            Mostrar();

            Limpiar();

            MessageBox.Show(
                "Usuario registrado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos =
                TUsuario.Buscar(
                    int.Parse(textBox1.Text));

            if (pos != -1)
            {
                Usuario obj = new Usuario();

                obj.IdUsuario =
                    int.Parse(textBox1.Text);

                obj.Nombre =
                    textBox2.Text;

                obj.Cedula =
                    textBox3.Text;

                obj.Correo =
                    textBox4.Text;

                obj.Telefono =
                    textBox5.Text;

                TUsuario.Editar(pos, obj);

                Mostrar();

                Limpiar();

                MessageBox.Show(
                    "Usuario editado");
            }
            else
            {
                MessageBox.Show(
                    "Usuario no encontrado");
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int pos =
                    dataGridView1.CurrentRow.Index;

                DialogResult r =
                    MessageBox.Show(
                        "¿Desea eliminar el usuario?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    TUsuario.Eliminar(pos);

                    Mostrar();

                    Limpiar();

                    MessageBox.Show(
                        "Usuario eliminado");
                }
            }
            else
            {
                MessageBox.Show(
                    "Seleccione un usuario");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
