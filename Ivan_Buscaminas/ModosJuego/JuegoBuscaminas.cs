using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Media;

namespace Ivan_Buscaminas
{
    public partial class JuegoBuscaminas : Form
    {
        int tamaño = 0;
        int numeroMinas = 0;
        Graphics g;
        Random Rand;
        int segundos = 0;
        private Boolean[,] mines;
        private Boolean[,] nums;
        private Boolean[,] DrNums;
        int[,] numb;
        private Boolean[,] blanks;
        private Boolean[,] Fblanks;
        private Boolean[,] exblanks;
        private Boolean[,] exblanksF;
        private Boolean[,] exists;
        private Boolean[,] marked;
        Rectangle[,] rect;
        Font font;
        Pen bPen, rPen;
        Brush yBrush, bBrush, blBrush, gBrush, rBrush, pBrush, oBrush, brBrush, piBrush;
        string modo;
        String userWin = Login.user.username;
       // public SoundPlayer explosion;
       // public SoundPlayer victoria;

        public JuegoBuscaminas(String m)
        {           
            InitializeComponent();

           
            modo = m;
          //  explosion = new SoundPlayer(Properties.Resources.Explosion);
          //  victoria = new SoundPlayer(Properties.Resources.victoria);
            //g = this.CreateGraphics();
            Rand = new Random();

            font = new Font("Microsoft Sans Serif", 18);
            bPen = new Pen(Color.Black);
            rPen = new Pen(Color.Red);
            yBrush = new SolidBrush(Color.LightGray);
            bBrush = new SolidBrush(Color.Black);
            blBrush = new SolidBrush(Color.Blue);
            gBrush = new SolidBrush(Color.Green);
            rBrush = new SolidBrush(Color.Red);
            pBrush = new SolidBrush(Color.Purple);
            oBrush = new SolidBrush(Color.Orange);
            brBrush = new SolidBrush(Color.Brown);
            piBrush = new SolidBrush(Color.Pink);

            mines = new Boolean[31, 31];
            nums = new Boolean[31, 31];
            DrNums = new Boolean[31, 31];
            numb = new int[31, 31];
            blanks = new Boolean[31, 31];
            Fblanks = new Boolean[31,31];
            exblanks = new Boolean[31, 31];
            exblanksF = new Boolean[31, 31];
            exists = new Boolean[31, 31];
            marked = new Boolean[31, 31];
            rect = new Rectangle[31, 31];

            mineClicked = false;

            imageMarked = new Bitmap(Properties.Resources.bandera30);
            imageMine = new Bitmap(Properties.Resources.mina30);

            count = 0;
            exblanksN = 0;
            exblanksFN = 0;
            Filled = 0;
            wCount = 0;


            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    exists[i, j] = false;
                    DrNums[i, j] = false;
                    Fblanks[i, j] = false;
                }
            }

            switch (modo)
            {
                case "Principiante":
                    crearBuscaminas(525, 525, 400, 10, 15);
                    break;
                case "Intermedio":
                    crearBuscaminas(750, 700, 550, 15, 35);
                    break;
                case "Avanzado":
                    crearBuscaminas(1000, 800, 750, 20, 75);
                    break;
                case "Arcade":                   
                    crearArcade(300, 260, 210, 5, 2);
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            lblTimer.Text = "Tiempo: " + segundos.ToString();
        }

        private void JuegoBuscaminas_MouseDown(object sender, MouseEventArgs e)
        {
            if (Lose == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        for (int j = 1; j < 31; j++)
                        {
                            if (rect[i, j].Contains(e.X, e.Y))
                            {
                                if (mines[i, j] == true)
                                {
                                    mineClicked = true;
                                    Lose = true;
                                    break;
                                }

                                else if (nums[i, j] == true)
                                {
                                    DrNums[i, j] = true;
                                    exists[i, j] = true;

                                    if (marked[i, j] == true)
                                    {
                                        marked[i, j] = false;
                                        mMines++;
                                    }
                                }

                                else if (blanks[i, j] == true)
                                {
                                    exists[i, j] = true;

                                    if (marked[i, j] == true)
                                    {
                                        marked[i, j] = false;
                                        mMines++;
                                    }

                                    if (exblanksF[i, j] == false)
                                    {
                                        Fblanks[i, j] = true;
                                        exists[i, j] = true;

                                        exblanksF[i, j] = true;
                                        exblanksFN++;

                                        if (marked[i, j] == true)
                                        {
                                            marked[i, j] = false;
                                            mMines++;
                                        }

                                        for (int a = 1; a > -2; a--)
                                        {
                                            for (int b = 1; b > -2; b--)
                                            {
                                                if (i - a < 0 || j - b < 0)
                                                {

                                                }

                                                else if (i - a > 29 || j - b > 30)
                                                {
                                                }

                                                else if (blanks[i - a, j - b] == true && exblanks[i - a, j - b] == false)
                                                {
                                                    Fblanks[i - a, j - b] = true;
                                                    exblanks[i - a, j - b] = true;
                                                    exblanksN++;
                                                    exists[i - a, j - b] = true;

                                                    if (marked[i - a, j - b] == true)
                                                    {
                                                        marked[i - a, j - b] = false;
                                                        mMines++;
                                                    }
                                                }

                                                else if (nums[i - a, j - b] == true)
                                                {
                                                    DrNums[i - a, j - b] = true;
                                                    exists[i - a, j - b] = true;

                                                    if (marked[i - a, j - b] == true)
                                                    {
                                                        marked[i - a, j - b] = false;
                                                        mMines++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    while (exblanksFN != exblanksN)
                    {
                        for (int R = 0; R < 30; R++)
                        {
                            for (int S = 1; S < 31; S++)
                            {
                                if (exblanks[R, S] == true && exblanksF[R, S] == false)
                                {
                                    exblanksFN++;
                                    exblanksF[R, S] = true;
                                    exists[R, S] = true;

                                    if (marked[R, S] == true)
                                    {
                                        marked[R, S] = false;
                                        mMines++;
                                    }

                                    for (int T = 1; T > -2; T--)
                                    {
                                        for (int U = 1; U > -2; U--)
                                        {
                                            if (R - T < 0 || S - U < 0)
                                            {

                                            }

                                            else if (R - T > 29 || S - U > 30)
                                            {

                                            }

                                            else if (blanks[R - T, S - U] == true && exblanks[R - T, S - U] == false)
                                            {
                                                Fblanks[R - T, S - U] = true;
                                                exblanks[R - T, S - U] = true;
                                                exblanksN++;
                                                exists[R - T, S - U] = true;

                                                if (marked[R - T, S - U] == true)
                                                {
                                                    marked[R - T, S - U] = false;
                                                    mMines++;
                                                }
                                            }

                                            else if (nums[R - T, S - U] == true)
                                            {
                                                DrNums[R - T, S - U] = true;
                                                exists[R - T, S - U] = true;

                                                if (marked[R - T, S - U] == true)
                                                {
                                                    marked[R - T, S - U] = false;
                                                    mMines++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (exblanksN == exblanksFN)
                        {
                            break;
                        }
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        for (int j = 1; j < 31; j++)
                        {
                            if (rect[i, j].Contains(e.X, e.Y) && exists[i, j] == true && marked[i, j] == false && DrNums[i, j] == false && Fblanks[i, j] == false && mMines > 0)
                            {
                                marked[i, j] = true;
                                mMines--;
                                break;
                            }
                            else if (rect[i, j].Contains(e.X, e.Y) && exists[i, j] == true && marked[i, j] == true && DrNums[i, j] == false && Fblanks[i, j] == false)
                            {
                                marked[i, j] = false;
                                mMines++;
                                break;
                            }
                        }
                    }
                }
              

                    wCount = 0;             
                    for (int i = 0; i < tamaño; i++)
                    {
                        for (int j = 1; j < tamaño+1; j++)
                        {                          

                            if (mMines == 0 && mines[i, j] == true && marked[i, j] == true)
                            {
                                wCount++;
                            }
                        }
                    }

                    if (wCount == numeroMinas)
                    {
                        if (modo.Equals("Arcade"))
                        {
                            switch (contador)
                            {
                            case 1:
                                contador++;
                                crearArcade(330, 280, 235, 6, 3);
                                break;
                            case 2:
                                contador++;
                                crearArcade(330, 280, 235, 6, 4);
                                break;
                            case 3:
                                contador++;
                                crearArcade(360, 310, 260, 7, 6);
                                break;
                            case 4:
                                contador++;
                                crearArcade(410, 340, 292, 8, 8);
                                break;
                            case 5:
                                contador++;
                                crearArcade(510, 400, 370, 10, 12);
                                break;
                            case 6:
                                contador++;
                                crearArcade(620, 460, 470, 12, 18);
                                break;
                            case 7:
                                contador++;
                                crearArcade(720, 520, 530, 14, 28);
                                break;
                            case 8:
                                contador++;
                                crearArcade(900, 610, 700, 17, 40);
                                break;
                            case 9:
                                contador++;
                                crearArcade(1000, 700, 750, 20, 60);
                                break;
                            case 10:
                                contador++;
                                crearArcade(1000, 700, 750, 20, 80);
                                break;
                            case 11:
                                contador++;
                                crearArcade(1000, 700, 750, 20, 100);
                                break;
                            case 12:
                                MessageBox.Show("¡Enhorabuena, has completado todos los niveles del modo Arcade!");
                                break;
                        }                            
                               
                        }
                    else
                    {
                        Win = true;
                    }
                    }                           
                Invalidate();
            }
        }

        private void pictureBoxReiniciar_Click(object sender, EventArgs e)
        {
            segundos = 0;
            switch (modo)
            {
                case "Principiante":
                    crearBuscaminas(525, 525, 400, 10, 15);
                    break;
                case "Intermedio":
                    crearBuscaminas(750, 700, 550, 15, 35);
                    break;
                case "Avanzado":
                    crearBuscaminas(1000, 800, 750, 20, 75);
                    break;
                case "Arcade":
                    contador = 1;
                    crearArcade(300, 260, 210, 5, 2);
                    break;
            }

        }
        int x, y, count, exblanksN, exblanksFN, mMines, Filled, wCount;
        private Image imageMarked, imageMine;
        private Boolean mineClicked, Lose, Win, Easy, Medium, Hard;
        private void JuegoBuscaminas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    g.DrawRectangle(bPen, rect[i, j]);

                    if (DrNums[i, j] == true && exists[i, j] == true)
                    {
                        g.FillRectangle(yBrush, rect[i, j]);

                        g.DrawString(numb[i, j].ToString(), font, bBrush, (i * 30) + 2, (j * 30) + 2);

                        if (numb[i, j] == 1)
                        {
                            g.DrawString(numb[i, j].ToString(), font, blBrush, (i * 30) + 2, (j * 30) + 2);
                        }

                        else if (numb[i, j] == 2)
                        {
                            g.DrawString(numb[i, j].ToString(), font, gBrush, (i * 30) + 2, (j * 30) + 2);
                        }

                        else if (numb[i, j] == 3)
                        {
                            g.DrawString(numb[i, j].ToString(), font, rBrush, (i * 30) + 2, (j * 30) + 2);
                        }

                        else if (numb[i, j] == 4)
                        {
                            g.DrawString(numb[i, j].ToString(), font, pBrush, (i * 30) + 2, (j * 30) + 2);
                        }

                        else if (numb[i, j] == 5)
                        {
                            g.DrawString(numb[i, j].ToString(), font, oBrush, (i * 30) + 2, (j * 30) + 2);
                        }

                        else if (numb[i, j] == 6)
                        {
                            g.DrawString(numb[i, j].ToString(), font, brBrush, (i * 30) + 2, (j * 30) + 2);
                        }

                        else if (numb[i, j] == 7)
                        {
                            g.DrawString(numb[i, j].ToString(), font, piBrush, (i * 30) + 2, (j * 30) + 2);
                        }
                    }

                    else if (Fblanks[i, j] == true && exists[i, j] == true)
                    {
                        g.FillRectangle(yBrush, rect[i, j]);
                    }

                    else if (mineClicked == true && mines[i, j] == true)
                    {
                        g.DrawImage(imageMine, i * 30, j * 30);
                    }

                    else if (marked[i, j] == true && exists[i, j] == true)
                    {
                        g.DrawImage(imageMarked, i * 30, j * 30);
                    }
                }
            }

            if (Lose == true)
            {
              //  explosion.Play();
                switch (modo)
                {
                    case "Principiante":
                        g.DrawString("¡Has perdido!", new Font("Microsoft Sans Serif", 30), rBrush, 50, 380);
                        break;
                    case "Intermedio":
                        g.DrawString("¡Has perdido!", new Font("Microsoft Sans Serif", 35), rBrush, 65, 520);
                        break;
                    case "Avanzado":
                        g.DrawString("¡Has perdido!", new Font("Microsoft Sans Serif", 40), rBrush, 100, 650);
                        break;
                    case "Arcade":
                        insertarPuntuacionArcade();
                        DialogResult respuesta= MessageBox.Show("Has conseguido pasarte " + (contador - 1) + " niveles... ¡Pulsa el botón de reinicio que hay debajo del nivel para volver a jugar!","¿VOLVER A JUGAR?",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (respuesta == DialogResult.OK)
                        { }
                        else
                        {
                            this.Hide();
                        }                  
                        break;

                        
                }
                           
               timer1.Stop();
               segundos = 0;              
            }

            else if (Win == true)
            {
                Win = false;
                insertarPuntuacion();                      
                timer1.Stop();
                MessageBox.Show("¡Has ganado! Has completado el buscaminas en " + segundos + " segundos!");                           
            }

            llblMinesLeft.Text = "Minas: " + mMines.ToString();
        }

        public void insertarPuntuacion() {

           
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.buscaminasConnectionString);

            switch (modo) {
                case "Principiante":
                    SqlCommand cmdP = new SqlCommand("EXECUTE insertar_principiante @usuario = @user, @tiempo = @time, @fecha = @date", conn);
                    cmdP.Parameters.AddWithValue("@user", userWin);
                    cmdP.Parameters.AddWithValue("@time", segundos);
                    cmdP.Parameters.AddWithValue("@date", DateTime.Now);
                    SqlDataAdapter daP = new SqlDataAdapter(cmdP);
                    DataTable dtP = new DataTable();
                    daP.Fill(dtP);
                    break;

                case "Intermedio":
                    SqlCommand cmdI = new SqlCommand("EXECUTE insertar_intermedio @usuario = @user, @tiempo = @time, @fecha = @date", conn);
                    cmdI.Parameters.AddWithValue("@user", userWin);
                    cmdI.Parameters.AddWithValue("@time", segundos);
                    cmdI.Parameters.AddWithValue("@date", DateTime.Now);
                    SqlDataAdapter daI = new SqlDataAdapter(cmdI);
                    DataTable dtI = new DataTable();
                    daI.Fill(dtI);
                    break;

                case "Avanzado":
                    SqlCommand cmdA = new SqlCommand("EXECUTE insertar_avanzado @usuario = @user, @tiempo = @time, @fecha = @date", conn);
                    cmdA.Parameters.AddWithValue("@user", userWin);
                    cmdA.Parameters.AddWithValue("@time", segundos);
                    cmdA.Parameters.AddWithValue("@date", DateTime.Now);
                    SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                    DataTable dtA = new DataTable();
                    daA.Fill(dtA);
                    break;
            }                    
        }

        public void insertarPuntuacionArcade() {
            Lose = false;         
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.buscaminasConnectionString);
            SqlCommand cmdP = new SqlCommand("EXECUTE insertar_arcade @usuario = @user, @niveles = @niveles, @fecha = @date", conn);
            cmdP.Parameters.AddWithValue("@user", userWin);
            cmdP.Parameters.AddWithValue("@niveles", contador-1);
            cmdP.Parameters.AddWithValue("@date", DateTime.Now);
            SqlDataAdapter daP = new SqlDataAdapter(cmdP);
            DataTable dtP = new DataTable();
            daP.Fill(dtP);
     
        }
        
        private void crearBuscaminas(int size1, int size2, int lbl1, int tablero, int minas)
        {
            lblNiveles.Hide();
            tamaño = tablero;
            numeroMinas = minas;
            Size = new Size(size1, size2);
            llblMinesLeft.SetBounds(lbl1, 30, llblMinesLeft.Width, llblMinesLeft.Height);
            lblTimer.SetBounds(lbl1, 50, llblMinesLeft.Width, llblMinesLeft.Height);
            pictureBoxReiniciar.SetBounds(lbl1, 70, pictureBoxReiniciar.Width, pictureBoxReiniciar.Height);
            Easy = true;
            Medium = false;
            Hard = false;
            mineClicked = false;

            count = 0;
            exblanksN = 0;
            exblanksFN = 0;
            Filled = 0;
            wCount = 0;

            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    mines[i, j] = false;
                    nums[i, j] = false;
                    DrNums[i, j] = false;
                    numb[i, j] = 0;
                    blanks[i, j] = false;
                    Fblanks[i, j] = false;
                    exblanks[i, j] = false;
                    exblanksF[i, j] = false;
                    exists[i, j] = false;
                    marked[i, j] = false;
                    rect[i, j] = new Rectangle(0, 0, 0, 0);

                    Lose = false;
                    Win = false;
                }
            }

            for (int i = 0; i < tablero; i++)
            {
                for (int j = 1; j < tablero+1; j++)
                {
                    rect[i, j] = new Rectangle(i * 30, j * 30, 30, 30);
                }
            }

            for (int i = 0; i < minas; i++)
            {
                x = Rand.Next(0, tablero);
                y = Rand.Next(1, tablero+1);

                while (mines[x, y] == true)
                {
                    x = Rand.Next(0, tablero);
                    y = Rand.Next(1, tablero+1);
                }

                if (exists[x, y] == false)
                {
                    mines[x, y] = true;
                    exists[x, y] = true;
                }
            }

            for (int i = 0; i < tablero; i++)
            {
                for (int j = 1; j < tablero+1; j++)
                {
                    count = 0;

                    if (exists[i, j] == true)
                    {

                    }

                    else if (exists[i, j] == false)
                    {
                        for (int a = 1; a > -2; a--)
                        {
                            for (int b = 1; b > -2; b--)
                            {
                                if (i - a < 0 || j - b < 0)
                                {

                                }

                                else if (mines[i - a, j - b] == true)
                                {
                                    count++;
                                }
                            }
                        }

                        if (count > 0)
                        {
                            nums[i, j] = true;
                            exists[i, j] = true;
                            numb[i, j] = count;
                        }

                        else if (count == 0)
                        {
                            blanks[i, j] = true;
                            exists[i, j] = true;
                        }
                    }
                }
            }

            mMines = minas;
            llblMinesLeft.Text = "Minas: " + mMines.ToString();
            lblTimer.Text = "Tiempo: 0";
            timer1.Start();
            Invalidate();
        }

        int contador = 1;
        private void crearArcade(int size1, int size2, int lbl1, int tablero, int minas)
        {
            tamaño = tablero;
            numeroMinas = minas;
            Size = new Size(size1, size2);
            llblMinesLeft.SetBounds(lbl1, 30, llblMinesLeft.Width, llblMinesLeft.Height);
            lblTimer.SetBounds(lbl1, 50, llblMinesLeft.Width, llblMinesLeft.Height);
            lblNiveles.SetBounds(lbl1, 70, llblMinesLeft.Width, llblMinesLeft.Height);           
            pictureBoxReiniciar.SetBounds(lbl1+10, 90, pictureBoxReiniciar.Width, pictureBoxReiniciar.Height);
            Easy = true;
            Medium = false;
            Hard = false;
            mineClicked = false;

            count = 0;
            exblanksN = 0;
            exblanksFN = 0;
            Filled = 0;
            wCount = 0;

            if (contador < 4) {             
                Font chiquita = new Font("Microsoft Sans Serif", 10);
                llblMinesLeft.Font = chiquita;
                lblTimer.Font = chiquita;
                lblNiveles.Font = chiquita;
            }
            else
            {
                Font normal = new Font("Microsoft Sans Serif", 18);
            }

            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    mines[i, j] = false;
                    nums[i, j] = false;
                    DrNums[i, j] = false;
                    numb[i, j] = 0;
                    blanks[i, j] = false;
                    Fblanks[i, j] = false;
                    exblanks[i, j] = false;
                    exblanksF[i, j] = false;
                    exists[i, j] = false;
                    marked[i, j] = false;
                    rect[i, j] = new Rectangle(0, 0, 0, 0);

                    Lose = false;
                    Win = false;
                }
            }

            for (int i = 0; i < tablero; i++)
            {
                for (int j = 1; j < tablero + 1; j++)
                {
                    rect[i, j] = new Rectangle(i * 30, j * 30, 30, 30);
                }
            }

            for (int i = 0; i < minas; i++)
            {
                x = Rand.Next(0, tablero);
                y = Rand.Next(1, tablero + 1);

                while (mines[x, y] == true)
                {
                    x = Rand.Next(0, tablero);
                    y = Rand.Next(1, tablero + 1);
                }

                if (exists[x, y] == false)
                {
                    mines[x, y] = true;
                    exists[x, y] = true;
                }
            }

            for (int i = 0; i < tablero; i++)
            {
                for (int j = 1; j < tablero + 1; j++)
                {
                    count = 0;

                    if (exists[i, j] == true)
                    {

                    }

                    else if (exists[i, j] == false)
                    {
                        for (int a = 1; a > -2; a--)
                        {
                            for (int b = 1; b > -2; b--)
                            {
                                if (i - a < 0 || j - b < 0)
                                {

                                }

                                else if (mines[i - a, j - b] == true)
                                {
                                    count++;
                                }
                            }
                        }

                        if (count > 0)
                        {
                            nums[i, j] = true;
                            exists[i, j] = true;
                            numb[i, j] = count;
                        }

                        else if (count == 0)
                        {
                            blanks[i, j] = true;
                            exists[i, j] = true;
                        }
                    }
                }
            }
            timer1.Start();
            mMines = minas;
            llblMinesLeft.Text = "Minas: " + mMines.ToString();
            lblTimer.Text = "Tiempo: 0 ";
            lblNiveles.Text = "Nivel " + contador;
            Invalidate();
        }
    }
}
