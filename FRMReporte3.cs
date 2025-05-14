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
    public partial class FRMReporte3 : Form
    {
        public FRMReporte3()
        {
            InitializeComponent();
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string rutaResources = Path.Combine(rutaProyecto, "Base_de_Datos");
            string rutaArchivo = Path.Combine(rutaResources, "Productos.xml");


            dataSet11.ReadXml(rutaArchivo);
        }
        
        private void FRMReporte3_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }     

}
