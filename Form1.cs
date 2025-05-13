using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppArchivosGrupo1
{
    public partial class Form1 : Form
    {

        string bienvenida = "Bienvenido";
        string espacio = "  "; 
        public Form1()
        {
            InitializeComponent();
        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Archivos archivos = new Archivos();
            archivos.crearArchivoXml();
        }
        
        public void RecibirInformacion(string informacion)
        {
            string nombre = informacion;
            label1.Text = bienvenida + espacio + nombre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FRMMENUPRODUCTOS objmenuproductos = new FRMMENUPRODUCTOS();
            objmenuproductos.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FRNReportes objreportes = new FRNReportes();
            objreportes.Show();
        }
    }
}
