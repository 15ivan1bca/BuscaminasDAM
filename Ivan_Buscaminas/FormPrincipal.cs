using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Ivan_Buscaminas
{
    public partial class FormPrincipal : Form
    {
        public SoundPlayer Cancion;
        public Boolean play = true;

        public FormPrincipal()
        {
            InitializeComponent();
            Cancion = new SoundPlayer(Properties.Resources.cancion_menu);     
            Cancion.PlayLooping();
        }

        //Eventos de los botones, labels etc.
        private void btnModos_Click(object sender, EventArgs e)
        {
            ModosDeJuego formModos = new ModosDeJuego();
            formModos.Show();
        }

        private void btnRankings_Click(object sender, EventArgs e)
        {
            Rankings rankings = new Rankings();
            rankings.Show();   
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            ComoJugar comojugar = new ComoJugar();
            comojugar.Show();  
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir del juego?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else {}
        }
        private void btnModos_MouseMove(object sender, MouseEventArgs e)
        {
            btnModos.BackColor = Color.Red;
            btnModos.ForeColor = Color.White;
            btnModos.FlatAppearance.BorderSize = 0;

        }

        private void btnModos_MouseLeave(object sender, EventArgs e)
        {
            btnModos.BackColor = Color.White;
            btnModos.ForeColor = Color.Red;
            btnModos.FlatAppearance.BorderSize = 3;
        }


        private void btnRankings_MouseMove(object sender, MouseEventArgs e)
        {
            btnRankings.BackColor = Color.Red;
            btnRankings.ForeColor = Color.White;
            btnRankings.FlatAppearance.BorderSize = 0;

        }

        private void btnRankings_MouseLeave(object sender, EventArgs e)
        {
            btnRankings.BackColor = Color.White;
            btnRankings.ForeColor = Color.Red;
            btnRankings.FlatAppearance.BorderSize = 3;
        }

        private void btnOpciones_MouseMove(object sender, MouseEventArgs e)
        {
            btnOpciones.BackColor = Color.Black;
            btnOpciones.ForeColor = Color.White;

        }

        private void btnOpciones_MouseLeave(object sender, EventArgs e)
        {
            btnOpciones.BackColor = Color.White;
            btnOpciones.ForeColor = Color.Black;
        }
        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.Black;
            btnSalir.ForeColor = Color.White;

        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.White;
            btnSalir.ForeColor = Color.Black;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                Cancion.Stop();
                play = false;
                pbSonido.Image = Properties.Resources.sonido_mute;
            }
            else
            {
                Cancion.PlayLooping();
                play = true;
                pbSonido.Image = Properties.Resources.sonido;
            }

        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }

}
