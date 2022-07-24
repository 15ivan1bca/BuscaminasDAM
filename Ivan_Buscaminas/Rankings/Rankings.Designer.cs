namespace Ivan_Buscaminas
{
    partial class Rankings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rankings));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buscaminasDataSet = new Ivan_Buscaminas.buscaminasDataSet();
            this.buscaminasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRecords = new Ivan_Buscaminas.boton();
            this.btnMisPuntuaciones = new Ivan_Buscaminas.boton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-- Modos básicos",
            "Principiante",
            "Intermedio",
            "Avanzado",
            "--Otros modos",
            "Arcade"});
            this.comboBox1.Location = new System.Drawing.Point(27, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(751, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Principiante";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(27, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 342);
            this.dataGridView1.TabIndex = 1;
            // 
            // buscaminasDataSet
            // 
            this.buscaminasDataSet.DataSetName = "buscaminasDataSet";
            this.buscaminasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscaminasDataSetBindingSource
            // 
            this.buscaminasDataSetBindingSource.DataSource = this.buscaminasDataSet;
            this.buscaminasDataSetBindingSource.Position = 0;
            // 
            // btnRecords
            // 
            this.btnRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRecords.BackColor = System.Drawing.Color.White;
            this.btnRecords.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRecords.FlatAppearance.BorderSize = 3;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.Color.Red;
            this.btnRecords.Location = new System.Drawing.Point(833, 10);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(160, 173);
            this.btnRecords.TabIndex = 7;
            this.btnRecords.Text = "RECORDS GLOBALES";
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnMisPuntuaciones
            // 
            this.btnMisPuntuaciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMisPuntuaciones.BackColor = System.Drawing.Color.White;
            this.btnMisPuntuaciones.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMisPuntuaciones.FlatAppearance.BorderSize = 3;
            this.btnMisPuntuaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisPuntuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisPuntuaciones.ForeColor = System.Drawing.Color.Red;
            this.btnMisPuntuaciones.Location = new System.Drawing.Point(833, 200);
            this.btnMisPuntuaciones.Name = "btnMisPuntuaciones";
            this.btnMisPuntuaciones.Size = new System.Drawing.Size(160, 173);
            this.btnMisPuntuaciones.TabIndex = 6;
            this.btnMisPuntuaciones.Text = "MIS PUNTAJES";
            this.btnMisPuntuaciones.UseVisualStyleBackColor = false;
            this.btnMisPuntuaciones.Click += new System.EventHandler(this.btnMisPuntuaciones_Click);
            // 
            // Rankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::Ivan_Buscaminas.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 383);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnMisPuntuaciones);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rankings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rankings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscaminasDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource buscaminasDataSetBindingSource;
        private buscaminasDataSet buscaminasDataSet;
        private boton btnMisPuntuaciones;
        private boton btnRecords;
    }
}