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
        string cedula, nombre, apellido, direccion, ciudad, email = "";
        char estadoCivil = 'S', genero = 'M';
        int edadEnAnios;
        DateTime fechaNac;

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LeerFechaNac();
            comboBox1.Focus();
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) genero = 'F';
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory;

                
                object[] vect = new object[11];

                LeerCedula();
                nombre = textBox2.Text.Trim();
                apellido = textBox3.Text.Trim();
                ciudad = comboBox1.SelectedItem.ToString();
                email = textBox4.Text.Trim();
                direccion = textBox5.Text.Trim();
                LeerFechaNac();

                DataRow[] datos;
             
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Todos los campos deben ser válidos y llenados.");
                Console.WriteLine("---RegistroUsuario---" + ex.Message);
            }
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                nombre = textBox2.Text.Trim();
                textBox3.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LeerCedula();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LeerCedula()
        {
            try
            {
                Cedula comprCedula = new Cedula(textBox1.Text);
                if (textBox1.Text.Length > 10)
                {
                    throw new Exception("Rata");
                }
                if (!comprCedula.ComprobarCedula())
                {
                    MessageBox.Show("Cédula inválida.");
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    cedula = textBox1.Text.Trim();
                    textBox2.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cédula no válida.");
                Console.WriteLine("---IngresoCedula---" + ex.Message);
            }
        }

        void LeerFechaNac()
        {
            fechaNac = dateTimePicker1.Value.Date;
            DateTime fechaActual = DateTime.Today;
            TimeSpan diferencia = fechaActual - fechaNac;

            edadEnAnios = (int)(diferencia.TotalDays / 365.25);
        }
    }
}