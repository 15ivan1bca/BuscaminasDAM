using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using Ivan_Buscaminas.Loginetc;

namespace Ivan_Buscaminas
{
    public partial class Login : Form
    {
        public String username;
        public static Usuario user;

        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername; //Pone el foco en el textBox del usuario al iniciar el formulario
        }

        private void iniciarSesion()
        {
            try
            {
                //Creamos la conexion a azure y hacemos la consulta
                String contraEncriptada = Encriptar(txtPassword.Text);

                SqlConnection conn = new SqlConnection(Properties.Settings.Default.buscaminasConnectionString);
                SqlCommand cmd = new SqlCommand("select * from usuarios where userName COLLATE Latin1_General_BIN = @username and userPassword COLLATE Latin1_General_BIN = @password", conn);
                cmd.Parameters.AddWithValue("username", txtUsername.Text);
                cmd.Parameters.AddWithValue("password", contraEncriptada);

                //Metemos los resultados en un datatable y si el usuario y contraseña coinciden accede a la app
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    user = new Usuario(txtUsername.Text);
                    username = txtUsername.Text;
                    this.Hide();
                    SplashScreen splash = new SplashScreen();
                    splash.Show();
                }
                else
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    MessageBox.Show("Usuario o contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debes estar conectado a internet", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //Metodo para recordar las credenciales para la próxima sesión
        private void recordarCredenciales() {

            if (CheckBoxRecordar.Checked == true) {
                
               // Los guarda en unas variables globales
                Properties.Settings.Default.Usuario = txtUsername.Text;
                Properties.Settings.Default.Contraseña = txtPassword.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();            
            }
            else
            {            
                Properties.Settings.Default.Contraseña = "";
                Properties.Settings.Default.Usuario = "";
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();             
            }
            
        }

        static string Encriptar(string value)
        {

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }

        }

        //Eventos de los botones, labels etc.
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {       
            recordarCredenciales();
            iniciarSesion();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }

        public Boolean ojo = true;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ojo == true)
            {
                pictureBox3.Image = Properties.Resources.ojoTapado;
                txtPassword.PasswordChar = '\0';
                ojo = false;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.ojo;
                txtPassword.PasswordChar = '*';
                ojo = true;
            }
        }
        
        private void lblRegister_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblRegister.ForeColor = Color.Black;

        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.Red;
            this.Cursor = Cursors.Default;
        }

        private void lblForgotPassword_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblForgotPassword.ForeColor = Color.Black;
        }

        private void lblForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            lblForgotPassword.ForeColor = Color.Red;
            this.Cursor = Cursors.Default;
        }

        private void btnIniciarSesion_MouseMove(object sender, MouseEventArgs e)
        {
            btnIniciarSesion.BackColor = Color.Red;
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;
        }

        private void btnIniciarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnIniciarSesion.BackColor = Color.White;
            btnIniciarSesion.ForeColor = Color.Red;
            btnIniciarSesion.FlatAppearance.BorderSize = 3;
            this.Cursor = Cursors.Default;
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ContraseñaOlvidada form = new ContraseñaOlvidada();
            form.Show();
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }

        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtUsername.Focus();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciarSesion();
            }

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciarSesion();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciarSesion();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.Usuario;
            txtPassword.Text = Properties.Settings.Default.Contraseña;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
