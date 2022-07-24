namespace Ivan_Buscaminas
{
    partial class JuegoBuscaminas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoBuscaminas));
            this.llblMinesLeft = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxReiniciar = new System.Windows.Forms.PictureBox();
            this.lblNiveles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReiniciar)).BeginInit();
            this.SuspendLayout();
            // 
            // llblMinesLeft
            // 
            this.llblMinesLeft.AutoSize = true;
            this.llblMinesLeft.BackColor = System.Drawing.Color.Transparent;
            this.llblMinesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblMinesLeft.ForeColor = System.Drawing.Color.Black;
            this.llblMinesLeft.Location = new System.Drawing.Point(659, 7);
            this.llblMinesLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblMinesLeft.Name = "llblMinesLeft";
            this.llblMinesLeft.Size = new System.Drawing.Size(50, 15);
            this.llblMinesLeft.TabIndex = 0;
            this.llblMinesLeft.Text = "Minas:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(659, 28);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(63, 15);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "Tiempo: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxReiniciar
            // 
            this.pictureBoxReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxReiniciar.Image = global::Ivan_Buscaminas.Properties.Resources.reiniciar2;
            this.pictureBoxReiniciar.Location = new System.Drawing.Point(662, 53);
            this.pictureBoxReiniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxReiniciar.Name = "pictureBoxReiniciar";
            this.pictureBoxReiniciar.Size = new System.Drawing.Size(29, 35);
            this.pictureBoxReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReiniciar.TabIndex = 2;
            this.pictureBoxReiniciar.TabStop = false;
            this.pictureBoxReiniciar.Click += new System.EventHandler(this.pictureBoxReiniciar_Click);
            // 
            // lblNiveles
            // 
            this.lblNiveles.AutoSize = true;
            this.lblNiveles.BackColor = System.Drawing.Color.Transparent;
            this.lblNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveles.ForeColor = System.Drawing.Color.Black;
            this.lblNiveles.Location = new System.Drawing.Point(659, 53);
            this.lblNiveles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNiveles.Name = "lblNiveles";
            this.lblNiveles.Size = new System.Drawing.Size(133, 15);
            this.lblNiveles.TabIndex = 3;
            this.lblNiveles.Text = "Niveles superados: ";
            // 
            // JuegoBuscaminas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ivan_Buscaminas.Properties.Resources.fondo5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 620);
            this.Controls.Add(this.lblNiveles);
            this.Controls.Add(this.pictureBoxReiniciar);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.llblMinesLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "JuegoBuscaminas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscaminas";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.JuegoBuscaminas_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JuegoBuscaminas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReiniciar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llblMinesLeft;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxReiniciar;
        private System.Windows.Forms.Label lblNiveles;
    }
}