namespace SistemaBibliotecario.Formulario
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLibros
            // 
            this.btnLibros.Location = new System.Drawing.Point(110, 54);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(168, 78);
            this.btnLibros.TabIndex = 0;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(114, 147);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(164, 78);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Location = new System.Drawing.Point(114, 240);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(164, 79);
            this.btnPrestamos.TabIndex = 2;
            this.btnPrestamos.Text = "Prestamos";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(114, 351);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(164, 56);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnLibros);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnSalir;
    }
}