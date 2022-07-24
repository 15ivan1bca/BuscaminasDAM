using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivan_Buscaminas
{
    public partial class ComoJugar : Form
    {
        public ComoJugar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Añade el formulario2 al panel
            panel.Visible = true;
            ComoJugar2 comoJugar2 = new ComoJugar2();
            comoJugar2.FormBorderStyle = FormBorderStyle.None;
            comoJugar2.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(comoJugar2);
            comoJugar2.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
