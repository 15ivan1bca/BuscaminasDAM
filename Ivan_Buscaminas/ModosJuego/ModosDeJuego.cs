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
    public partial class ModosDeJuego : Form    //Formulario para iniciar el juego del buscaminas dependiendo del modo de juego que elijas
    {
        public ModosDeJuego()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            String modoBasico = comboBoxModoBasico.Text;
            if (modoBasico == "Principiante" || modoBasico == "Intermedio" || modoBasico == "Avanzado" || modoBasico == "Arcade")
            {
                JuegoBuscaminas princ = new JuegoBuscaminas(modoBasico);
                princ.Show();
                Hide();
            }

            else {
                
                MessageBox.Show("Debes seleccionar un modo de juego válido", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                              
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.flecharoja;
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.flecharoja2;
            this.Cursor = Cursors.Hand;
        }

    }
}
