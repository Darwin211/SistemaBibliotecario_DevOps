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
    public partial class FrmLibros : Form
    {
        public FrmLibros()
        {
            InitializeComponent();
          
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
        public void Datos()
        {
            TLibro.ListaLibros.Add(new Libro
            {
                Id = 1,
                Titulo = "El Quijote",
                Autor = "Miguel de Cervantes",
                categoria = "Novela",
                stock = 5
            });
            TLibro.ListaLibros.Add(new Libro
            {
                Id = 2,
                Titulo = "Cien Años de Soledad",
                Autor = "Gabriel García Márquez",
                categoria = "Novela",
                stock = 3
            });
            TLibro.ListaLibros.Add(new Libro
            {
                Id = 3,
                Titulo = "La Sombra del Viento",
                Autor = "Carlos Ruiz Zafón",
                categoria = "Novela",
                stock = 4
            });
        }
        public void listar()
        {
            dataGridView1.DataSource = Controlador.TLibro.ListaLibros.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Libro obj = new Libro();
            obj.Id = int.Parse(textBox1.Text);
            obj.Titulo = textBox2.Text;
            obj.Autor = textBox3.Text;
            obj.categoria = textBox4.Text;
            obj.stock = int.Parse(textBox5.Text);

            TLibro.Agregar(obj);

            listar();
            Limpiar();

            MessageBox.Show("Libro agregado correctamente");
        }

        private void FrmLiibros_Load(object sender, EventArgs e)
        {
            Datos();
            listar();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos =
               TLibro.Buscar(
                   int.Parse(textBox1.Text));

            if (pos != -1)
            {
                Libro obj = new Libro();

                obj.Id =
                    int.Parse(textBox1.Text);

                obj.Titulo =
                    textBox2.Text;

                obj.Autor =
                    textBox3.Text;

                obj.categoria =
                    textBox4.Text;

                obj.stock =
                    int.Parse(textBox5.Text);

                TLibro.Editar(pos, obj);

                listar();

                Limpiar();

                MessageBox.Show(
                    "Libro editado");
            }
            else
            {
                MessageBox.Show(
                    "Libro no encontrado");
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
                        "¿Desea eliminar el libro?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    TLibro.Eliminar(pos);

                    listar();

                    Limpiar();

                    MessageBox.Show(
                        "Libro eliminado");
                }
            }
            else
            {
                MessageBox.Show(
                    "Seleccione un libro");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close  ();
        }
    }
}
