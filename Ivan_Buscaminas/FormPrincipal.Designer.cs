namespace Ivan_Buscaminas
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSonido = new System.Windows.Forms.PictureBox();
            this.btnSalir = new Ivan_Buscaminas.boton();
            this.btnOpciones = new Ivan_Buscaminas.boton();
            this.btnRankings = new Ivan_Buscaminas.boton();
            this.btnModos = new Ivan_Buscaminas.boton();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSonido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Ivan_Buscaminas.Properties.Resources.buscamina_grande1;
            this.pbLogo.Location = new System.Drawing.Point(92, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(340, 144);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pbSonido);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnOpciones);
            this.panel1.Controls.Add(this.btnRankings);
            this.panel1.Controls.Add(this.btnModos);
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 493);
            this.panel1.TabIndex = 9;
            // 
            // pbSonido
            // 
            this.pbSonido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbSonido.Image = global::Ivan_Buscaminas.Properties.Resources.sonido;
            this.pbSonido.Location = new System.Drawing.Point(0, 459);
            this.pbSonido.Name = "pbSonido";
            this.pbSonido.Size = new System.Drawing.Size(34, 34);
            this.pbSonido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSonido.TabIndex = 9;
            this.pbSonido.TabStop = false;
            this.pbSonido.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(180, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 50);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseMove);
            // 
            // btnOpciones
            // 
            this.btnOpciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpciones.BackColor = System.Drawing.Color.White;
            this.btnOpciones.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOpciones.FlatAppearance.BorderSize = 3;
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpciones.ForeColor = System.Drawing.Color.Black;
            this.btnOpciones.Location = new System.Drawing.Point(180, 300);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(150, 50);
            this.btnOpciones.TabIndex = 7;
            this.btnOpciones.Text = "SOBRE EL JUEGO";
            this.btnOpciones.UseVisualStyleBackColor = false;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            this.btnOpciones.MouseLeave += new System.EventHandler(this.btnOpciones_MouseLeave);
            this.btnOpciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOpciones_MouseMove);
            // 
            // btnRankings
            // 
            this.btnRankings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRankings.BackColor = System.Drawing.Color.White;
            this.btnRankings.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRankings.FlatAppearance.BorderSize = 3;
            this.btnRankings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRankings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRankings.ForeColor = System.Drawing.Color.Red;
            this.btnRankings.Location = new System.Drawing.Point(180, 150);
            this.btnRankings.Name = "btnRankings";
            this.btnRankings.Size = new System.Drawing.Size(150, 50);
            this.btnRankings.TabIndex = 6;
            this.btnRankings.Text = "RANKINGS";
            this.btnRankings.UseVisualStyleBackColor = false;
            this.btnRankings.Click += new System.EventHandler(this.btnRankings_Click);
            this.btnRankings.MouseLeave += new System.EventHandler(this.btnRankings_MouseLeave);
            this.btnRankings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRankings_MouseMove);
            // 
            // btnModos
            // 
            this.btnModos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModos.BackColor = System.Drawing.Color.White;
            this.btnModos.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnModos.FlatAppearance.BorderSize = 3;
            this.btnModos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModos.ForeColor = System.Drawing.Color.Red;
            this.btnModos.Location = new System.Drawing.Point(180, 51);
            this.btnModos.Name = "btnModos";
            this.btnModos.Size = new System.Drawing.Size(150, 50);
            this.btnModos.TabIndex = 5;
            this.btnModos.Text = "MODOS DE JUEGO";
            this.btnModos.UseVisualStyleBackColor = false;
            this.btnModos.Click += new System.EventHandler(this.btnModos_Click);
            this.btnModos.MouseLeave += new System.EventHandler(this.btnModos_MouseLeave);
            this.btnModos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnModos_MouseMove);
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "ProductCategory";
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Ivan_Buscaminas.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbLogo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscaminas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSonido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private boton btnModos;
        private boton btnRankings;
        private boton btnOpciones;
        private boton btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSonido;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
    }
}

