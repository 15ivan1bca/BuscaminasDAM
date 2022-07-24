using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Ivan_Buscaminas
{
    public partial class ContraseñaOlvidada : Form      //Formulario para resetear la contraseña
    {
        string randomCode;
        public static string to;

        public ContraseñaOlvidada()
        {
            InitializeComponent();
        }

        //Metodo que hace todo lo del email mediante smtp e insertar el codigo
        private void btnOlvidada()
        {

            String pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"; //Regex para comprobar el formato del email


            if (btnCodigo.Text == "VERIFICAR CODIGO")
            {
                if (randomCode == (txtVerificar.Text)) //Si el codigo enviado coincide con el textBox se abre el formulario para resetear la contraseña
                {
                    nuevaContraseña n = new nuevaContraseña(to);
                    n.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El codigo no es correcto");
                }

            }

            if (btnCodigo.Text == "SOLICITAR CODIGO")
            {
                if (Regex.IsMatch(txtMail.Text, pattern)) //Comprueba que el formato del email sea valido
                {

                    SqlConnection conn = new SqlConnection(Properties.Settings.Default.buscaminasConnectionString);
                    SqlCommand cmd = new SqlCommand("select * from usuarios where userMail COLLATE Latin1_General_BIN = @mail", conn);
                    cmd.Parameters.AddWithValue("mail", txtMail.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        string from, pass, messageBody;
                        Random r = new Random();
                        randomCode = r.Next(999999).ToString();

                        MailMessage message = new MailMessage();
                        to = txtMail.Text;

                        //cuenta y contraseña del email utilizado para enviar el codigo
                        from = ConfigurationManager.AppSettings["emailfrom"];
                        pass = ConfigurationManager.AppSettings["emailpass"];                    
                        //Se hace toda la conexion smtp
                        messageBody = "Tu código para resetear la contraseña es: " + randomCode;
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = messageBody;
                        message.Subject = "Reseteo de contraseña";
                        SmtpClient smtp = new SmtpClient("smtp.office365.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);

                        try
                        {
                            smtp.Send(message);
                            MessageBox.Show("Código enviado correctamente");
                            btnCodigo.Text = "VERIFICAR CODIGO";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Este email no existe en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Formato de email no valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //Eventos para los botones, labels etc
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            btnOlvidada();
        }

        private void ContraseñaOlvidada_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void txtMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOlvidada();
            }
        }
    }
}