using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ivan_Buscaminas
{
    public partial class Rankings : Form
    {
        String user = Login.user.username;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.buscaminasConnectionString);

        public Rankings()
        {
            InitializeComponent();
            consultaPrincipiante(); //Carga los datos del modo principiante por defecto
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            String modoJuego = comboBox1.Text;
            switch (modoJuego) //Dependiendo del modo de juego carga las diferentes tablas
            {               
                case "Principiante":
                    consultaPrincipiante();                 
                    break;
                case "Intermedio":
                    consultaIntermedio();
                    break;
                case "Avanzado":
                    consultaAvanzado();
                    break;
                case "Arcade":
                    consultaArcade();
                    break;
            }
        }

        /*
         * Metodos para conseguir los datos de la mejor puntuacion de cada usuario dependiendo de la dificultad
         * */
        private void consultaPrincipiante()
        {
            SqlCommand cmdp = new SqlCommand("execute seleccionar_principiante; ", conn);
            SqlDataAdapter dap = new SqlDataAdapter(cmdp);
            DataTable dtp = new DataTable();
            dap.Fill(dtp);
            dataGridView1.DataSource = dtp;
        }

        private void consultaIntermedio()
        {
            SqlCommand cmdi = new SqlCommand("execute seleccionar_intermedio;", conn);
            SqlDataAdapter dai = new SqlDataAdapter(cmdi);
            DataTable dti = new DataTable();
            dai.Fill(dti);
            dataGridView1.DataSource = dti;
        }

        private void consultaAvanzado()
        {
            SqlCommand cmda = new SqlCommand("execute seleccionar_avanzado", conn);
            SqlDataAdapter daa = new SqlDataAdapter(cmda);
            DataTable dta = new DataTable();
            daa.Fill(dta);
            dataGridView1.DataSource = dta;
        }

        private void consultaArcade()
        {
            SqlCommand cmda = new SqlCommand("execute seleccionar_arcade", conn);
            SqlDataAdapter daa = new SqlDataAdapter(cmda);
            DataTable dta = new DataTable();
            daa.Fill(dta);
            dataGridView1.DataSource = dta;
        }


        /*
         * Metodos para conseguir los datos de todas las puntuaciones del usuario que tiene la sesion iniciada
         * */
        private void consultaPrincipianteLocal()
        {
            SqlCommand cmdp = new SqlCommand("execute seleccionar_principiante_local @usuario = @user; ", conn);
            cmdp.Parameters.AddWithValue("@user", user );        
            SqlDataAdapter dap = new SqlDataAdapter(cmdp);
            DataTable dtp = new DataTable();
            dap.Fill(dtp);
            dataGridView1.DataSource = dtp;
        }

        private void consultaIntermedioLocal()
        {
            SqlCommand cmdi = new SqlCommand("execute seleccionar_intermedio_local @usuario = @user; ", conn);
            cmdi.Parameters.AddWithValue("@user", user);
            SqlDataAdapter dai = new SqlDataAdapter(cmdi);
            DataTable dti = new DataTable();
            dai.Fill(dti);
            dataGridView1.DataSource = dti;
        }

        private void consultaAvanzadoLocal()
        {
            SqlCommand cmda = new SqlCommand("execute seleccionar_avanzado_local @usuario = @user;", conn);
            cmda.Parameters.AddWithValue("@user", user);
            SqlDataAdapter daa = new SqlDataAdapter(cmda);
            DataTable dta = new DataTable();
            daa.Fill(dta);
            dataGridView1.DataSource = dta;
        }

        private void consultaArcadeLocal()
        {
            SqlCommand cmda = new SqlCommand("execute seleccionar_arcade_local @usuario = @user;", conn);
            cmda.Parameters.AddWithValue("@user", user);
            SqlDataAdapter daa = new SqlDataAdapter(cmda);
            DataTable dta = new DataTable();
            daa.Fill(dta);
            dataGridView1.DataSource = dta;
        }
        //Eventos para los botones, que ejecutan los metodos dependiendo de lo que esté seleccionado en el comboBox

        private void btnRecords_Click(object sender, EventArgs e)
        {
            String modoJuego = comboBox1.Text;
            switch (modoJuego)
            {
                case "Principiante":
                    consultaPrincipiante();
                    break;
                case "Intermedio":
                    consultaIntermedio();
                    break;
                case "Avanzado":
                    consultaAvanzado();
                    break;
                case "Arcade":
                    consultaArcade();
                    break;
            }
        }

        private void btnMisPuntuaciones_Click(object sender, EventArgs e)
        {
            String modoJuego = comboBox1.Text;
            switch (modoJuego)
            {
                case "Principiante":
                    consultaPrincipianteLocal();
                    break;
                case "Intermedio":
                    consultaIntermedioLocal();
                    break;
                case "Avanzado":
                    consultaAvanzadoLocal();
                    break;
                case "Arcade":
                    consultaArcadeLocal();
                    break;

            }
        }
    }
}
