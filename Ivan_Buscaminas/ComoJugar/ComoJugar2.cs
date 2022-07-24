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
    public partial class ComoJugar2 : Form
    {
        public ComoJugar2()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Al darle a la flecha de la izquierda, vuelve a poner el primer form en el panel
            panel1.Visible = true;
            ComoJugar comoJugar = new ComoJugar();
            comoJugar.FormBorderStyle = FormBorderStyle.None;
            comoJugar.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(comoJugar);
            comoJugar.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Al darle a la flecha de la derecha, pone el tercer form en el panel
            panel1.Visible = true;
            ComoJugar3 comoJugar3 = new ComoJugar3();
            comoJugar3.FormBorderStyle = FormBorderStyle.None;
            comoJugar3.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(comoJugar3);
            comoJugar3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
