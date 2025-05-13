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
    public partial class FRNreporte6 : Form
    {
        public FRNreporte6()
        {
            InitializeComponent();
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string rutaResources = Path.Combine(rutaProyecto, "Base_de_Datos");
            string rutaArchivo = Path.Combine(rutaResources, "Productos.xml");

        }

        private void FRNreporte6_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
