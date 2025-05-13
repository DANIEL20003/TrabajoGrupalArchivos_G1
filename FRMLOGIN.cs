using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinAppArchivosGrupo1
{
    public partial class FRMLOGIN : Form
    {
        private SoundPlayer soundPlayer;
        String usuario4 = "Erik Yumi";
        String usuario1 = "Daniel Quiguiri";
        String usuario2 = "Danny Allauca";
        String usuario3 = "Angel Gadvay";
        String usuario5 = "Kevin Parra";
        String usuario6 = "Andrea Vinueza";
        String usuario7 = "Alexander Villalva";
        String usuario8 = "Mateo López";
        String usuario9 = "Lorena Aguirre";

        string contra = "1234";
        public FRMLOGIN()
        {
            InitializeComponent();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }


        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == usuario1 || textBox1.Text == usuario2 || textBox1.Text == usuario3 || textBox1.Text == usuario4 || textBox1.Text == usuario5 || textBox1.Text == usuario6 || textBox1.Text == usuario7 || textBox1.Text == usuario8 || textBox1.Text == usuario9 || textBox2.Text == contra)
                {
                    Form1 objetopin = new Form1();

                    string informacion = textBox1.Text; // Obtener el texto del TextBox

                    // Pasar la información al segundo formulario
                    objetopin.RecibirInformacion(informacion);
                    objetopin.ShowDialog();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo");
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMLOGIN_Load(object sender, EventArgs e)
        {
            /*
           // bypass para no estar ingresando usuario y contrasenia durante las pruebas
           Pagina_principal objetopin = new Pagina_principal();
           objetopin.ShowDialog();*/

           

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int x = pictureBox4.Location.X;
            int y = pictureBox4.Location.Y;
            x = x + 5;
            if (x >= 360)
            {
                x = 10;
            }
            Point punto = new Point(x, y);
            pictureBox4.Location = punto;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroUsuario llmarform = new RegistroUsuario();
            llmarform.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btnregistrar.PerformClick();
            }
        }
    }
    }
    

