using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.IO;
using Microsoft.Reporting.WinForms;

namespace WinAppArchivosGrupo1
{
    public partial class FRMReporte2 : Form
    {
        string rutaArchivo;
        public FRMReporte2()
        {
            InitializeComponent();

            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string rutaResources = Path.Combine(rutaProyecto, "Base_de_Datos");
            rutaArchivo = Path.Combine(rutaResources, "Productos.xml");

            dataSet1.ReadXml(rutaArchivo);

        }

        private void FRMReporte2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

        }
    }
}
