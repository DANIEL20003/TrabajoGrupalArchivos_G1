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
        List<UsuarioInfo> listaUsuarios = new List<UsuarioInfo>();

        private SoundPlayer soundPlayer;

        byte intentos = 3;
        string contra = "1234";
        /*String usuario4 = "Erik Yumi";
        String usuario1 = "Daniel Quiguiri";
        String usuario2 = "Danny Allauca";
        String usuario3 = "Angel Gadvay";
        String usuario5 = "Kevin Parra";
        String usuario6 = "Andrea Vinueza";
        String usuario7 = "Alexander Villalva";
        String usuario8 = "Mateo López";
        String usuario9 = "Lorena Aguirre"*/
        public FRMLOGIN()
        {
            InitializeComponent();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txbUsuario.Text))
                {
                    MessageBox.Show("El campo de usuario no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbUsuario.Focus();
                    e.Handled = true;
                    return;
                }

                
                /*string[] usuariosPermitidos = {
                    usuario1, usuario2, usuario3, usuario4, usuario5,
                    usuario6, usuario7, usuario8, usuario9
                };

                if (!usuariosPermitidos.Contains(textBox1.Text))
                {
                    MessageBox.Show("Usuario no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox1.Focus();
                    e.Handled = true;
                    return;
                }*/

                txbContraseña.Focus();
            }
        }


        /*private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == usuario1 || textBox1.Text == usuario2 || textBox1.Text == usuario3 || textBox1.Text == usuario4 || textBox1.Text == usuario5 || textBox1.Text == usuario6 || textBox1.Text == usuario7 || textBox1.Text == usuario8 || textBox1.Text == usuario9) && textBox2.Text == contra)
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

        }*/

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMLOGIN_Load(object sender, EventArgs e)
        {
          

           

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
                btnIniciar.PerformClick();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistroUsuario llamarform = new RegistroUsuario();
            if (llamarform.ShowDialog() == DialogResult.OK)
            {
                string nuevoUsuario = llamarform.usuarioIngresar;
                string nuevaContraseña = llamarform.contraseñaIngresar;

                
                listaUsuarios.Add(new UsuarioInfo(nuevoUsuario,nuevaContraseña));
            }

        }

        private void FRMLOGIN_Load_1(object sender, EventArgs e)
        {
            listaUsuarios.Add(new UsuarioInfo("Daniel Quiguiri", contra));
            listaUsuarios.Add(new UsuarioInfo("Danny Allauca", contra));
            listaUsuarios.Add(new UsuarioInfo("Angel Gadvay", contra));
            listaUsuarios.Add(new UsuarioInfo("Erik Yumi", contra));
            listaUsuarios.Add(new UsuarioInfo("Kevin Parra", contra));
            listaUsuarios.Add(new UsuarioInfo("Andrea Vinueza", contra));
            listaUsuarios.Add(new UsuarioInfo("Alexander Villalva", contra));
            listaUsuarios.Add(new UsuarioInfo("Mateo López", contra));
            listaUsuarios.Add(new UsuarioInfo("Lorena Aguirre", contra));
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txbUsuario.Text;
            string contraseñaIngresada = txbContraseña.Text;

            bool existe = listaUsuarios.Any(u => u.Usuario == usuarioIngresado && u.Contraseña == contraseñaIngresada);

            if (existe)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 objform = new Form1();
                objform.ShowDialog();
            }
            else
            {
                intentos -= 1;
                MessageBox.Show($"Le quedan {intentos} intentos", "Usuario o contraseña incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                if (intentos > 0)
                {
                    txbUsuario.Clear();
                    txbContraseña.Clear();
                    txbUsuario.Focus();
                }
                else
                {
                    txbUsuario.Clear();
                    txbContraseña.Clear();
                    txbUsuario.Enabled = false;
                    txbContraseña.Enabled = false;
                    btnIniciar.Enabled = false;
                    btnRegistrarse.Enabled = false;
                }
                
            }
        }

        private void txbContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class UsuarioInfo
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public UsuarioInfo(string usuario, string contraseña)
        {
            Usuario = usuario;
            Contraseña = contraseña;
        }
    }
}
    

