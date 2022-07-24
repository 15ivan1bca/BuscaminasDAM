using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ivan_Buscaminas
{
    public partial class nuevaContraseña : Form
    {
        String email;
        public nuevaContraseña(String mail)
        {
            InitializeComponent();
            email = mail;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassword2.Text)
            {
                if (txtPassword.Text.Length >= 6 && txtPassword.Text.Any(char.IsDigit))
                {
                    SqlConnection conn = new SqlConnection(Properties.Settings.Default.buscaminasConnectionString);
                    SqlCommand cmdnc = new SqlCommand("UPDATE usuarios SET userPassword = @password WHERE userMail = @mail", conn);
                    cmdnc.Parameters.AddWithValue("password", txtPassword.Text);
                    cmdnc.Parameters.AddWithValue("mail", email);
                    SqlDataAdapter danc = new SqlDataAdapter(cmdnc);
                    DataTable dtnc = new DataTable();
                    danc.Fill(dtnc);
                    MessageBox.Show("Contraseña cambiada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("La contraseña debe de tener mínimo 6 caracteres y un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
