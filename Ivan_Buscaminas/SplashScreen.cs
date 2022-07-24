using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ivan_Buscaminas.Loginetc;

namespace Ivan_Buscaminas
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            lblBienvenido.Text = "BIENVENIDO " + Login.user.username + "!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {
              
                timer1.Stop();
                this.Hide();
                FormPrincipal form = new FormPrincipal();
                form.ShowDialog();
            }
        }
    }
}
