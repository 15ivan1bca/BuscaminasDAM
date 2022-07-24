using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace Ivan_Buscaminas
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }


        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
            String pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"; //Regex para que pilla el formarto del e-mail

            ////Creamos la conexion a azure y hacemos la consulta         
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.buscaminasConnectionString);
            SqlCommand cmd = new SqlCommand("select * from usuarios where userName = @username or userMail = @mail", conn);
            cmd.Parameters.AddWithValue("username", txtUsername.Text);
            cmd.Parameters.AddWithValue("mail", txtMail.Text);
            //Metemos los resultados en un datatable y si no hay ningun usuario lo crea
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0) //Comprobación 1: ¿Existe el usuario o email?
            {
                if (Regex.IsMatch(txtMail.Text, pattern))  //Comprobación 2: ¿El formato del email es valido?
                {

                    if (txtPassword.Text == txtPasswordConfirm.Text) //Comprobacion 3: ¿Coinciden las contraseñas?
                    {
                        if (txtPassword.Text.Length >= 6 && txtPassword.Text.Any(char.IsDigit)) //Comprobación 4: ¿Tiene 6 caracteres y un numero?
                        {

                            //Inserta el usuario en la base de datos, pero antes la encripta
                            String contraEncriptada = Encriptar(txtPassword.Text);

                            SqlCommand cmd2 = new SqlCommand("insert into usuarios values (@username, @password, @mail)", conn);
                            cmd2.Parameters.AddWithValue("username", txtUsername.Text);
                            cmd2.Parameters.AddWithValue("password", contraEncriptada);
                            cmd2.Parameters.AddWithValue("mail", txtMail.Text);
                            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable();
                            da2.Fill(dt2);
                            MessageBox.Show("¡Registro realizado correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                else
                {
                    MessageBox.Show("Formato de email no valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
    

            }
            else
            {
                MessageBox.Show("¡El usuario o el e-mail ya existe!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }       
        }

        static string Encriptar(string value) {

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }

        }


        //Eventos de los botones
        private void btnRegistro_MouseMove(object sender, MouseEventArgs e)
        {
           btnRegistro.BackColor = Color.Red;
            btnRegistro.ForeColor = Color.White;
            btnRegistro.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;
        }

        private void btnRegistro_MouseLeave(object sender, EventArgs e)
        {
            btnRegistro.BackColor = Color.White;
            btnRegistro.ForeColor = Color.Red;
            btnRegistro.FlatAppearance.BorderSize = 3;
            this.Cursor = Cursors.Hand;
        }
    }
}

