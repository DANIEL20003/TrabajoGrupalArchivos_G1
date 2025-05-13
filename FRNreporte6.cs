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
        string rutaArchivo;
        public FRNreporte6()
        {
            InitializeComponent();
            
            
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string rutaResources = Path.Combine(rutaProyecto, "Base_de_Datos");
            rutaArchivo = Path.Combine(rutaResources, "Productos.xml");
            

        }

        private void FRNreporte6_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            if (File.Exists(rutaArchivo))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(rutaArchivo);

                // Asumiendo que tu ReportViewer espera una tabla llamada "Producto"
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(
                    new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[0])
                );


                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("El archivo Productos.xml no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
