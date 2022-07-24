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
    public partial class ComoJugar3 : Form
    {
        public ComoJugar3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            ComoJugar2 comoJugar2 = new ComoJugar2();
            comoJugar2.FormBorderStyle = FormBorderStyle.None;
            comoJugar2.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(comoJugar2);
            comoJugar2.Show();
        }
    }
}
