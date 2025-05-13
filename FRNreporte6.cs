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
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Productos.xml");
            dataSet1.ReadXml(rutaArchivo);
        }

        private void FRNreporte6_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
