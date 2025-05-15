using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppArchivosGrupo1
{
    public partial class RegistroUsuario : Form
    {
        public string usuarioIngresar { get; private set; }
        public string contraseñaIngresar { get; private set; }


        string cedula, nombre, apellido, direccion, ciudad, email = "";
        char estadoCivil = 'S', genero = 'M';
        int edadEnAnios;
        DateTime fechaNac;

        private List<Usuario> listaUsuarios = new List<Usuario>();



        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                apellido = textBox3.Text.Trim();
                dateTimePicker1.Focus();
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudad = comboBox1.SelectedItem.ToString();
            textBox4.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                direccion = textBox5.Text.Trim();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                estadoCivil = 'S';
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                estadoCivil = 'C';
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) genero = 'M';
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox3.Focus();
                e.Handled = true; 
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox4.Focus();
                e.Handled = true;
            }
        }

        private void TXB_registroU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TXB_crearC.Focus();
                e.Handled = true;
            }

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) genero = 'F';
        }



        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string usuarioNombre = TXB_registroU.Text.Trim();  
                string contraseña = TXB_crearC.Text.Trim();       
                string nombre = textBox2.Text.Trim();               
                string apellido = textBox3.Text.Trim();            
                string ciudad = comboBox1.SelectedItem.ToString(); 
                string email = textBox4.Text.Trim();                
                string direccion = textBox5.Text.Trim();            
                DateTime fechaNac = dateTimePicker1.Value.Date;     

                if (string.IsNullOrEmpty(usuarioNombre) || string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

         
                foreach (var usuario in listaUsuarios)
                {
                    if (usuario.UsuarioNombre == usuarioNombre)
                    {
                        MessageBox.Show("El usuario ya está registrado.");
                        return;
                    }
                }

                LeerCedula();

                int edadEnAnios = calcularEdad(fechaNac);
                if (edadEnAnios < 18)
                {
                    MessageBox.Show("Debe ser mayor de edad para registrarse.");
                    return;
                }

                usuarioIngresar = usuarioNombre;
                usuarioIngresar = contraseña;
                Usuario nuevoUsuario = new Usuario(usuarioNombre, contraseña);

              
                listaUsuarios.Add(nuevoUsuario);

              
                MessageBox.Show("Usuario creado exitosamente.");

                TXB_registroU.Clear();
                TXB_crearC.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
                Console.WriteLine("---RegistroUsuario---" + ex.Message);
            }
        }


        private int calcularEdad(DateTime fechaNac)
        {
            DateTime fechaActual = DateTime.Today;
            TimeSpan diferencia = fechaActual - fechaNac;
            return (int)(diferencia.TotalDays / 365.25);

        }

       
        void LeerCedula()
        {
            try
            {
                Cedula comprCedula = new Cedula(textBox1.Text);
                if (textBox1.Text.Length > 10)
                {
                    throw new Exception("La cédula no es válida.");
                }

                if (!comprCedula.ComprobarCedula())
                {
                    MessageBox.Show("Cédula inválida.");
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    // Almacenar la cédula si es válida
                    string cedula = textBox1.Text.Trim();
                    textBox2.Focus();  // Mover el foco al siguiente campo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cédula no válida.");
                Console.WriteLine("---IngresoCedula---" + ex.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LeerCedula();
            }
        }
    }
}