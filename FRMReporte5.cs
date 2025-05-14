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
using Microsoft.Reporting.WinForms;

namespace WinAppArchivosGrupo1
{
    public partial class FRMReporte5 : Form
    {
        string rutaArchivo;
        public FRMReporte5()
        {
            InitializeComponent();
            // Calcula la ruta del archivo XML
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string rutaResources = Path.Combine(rutaProyecto, "Base_de_Datos");
            rutaArchivo = Path.Combine(rutaResources, "Productos.xml");
        }

        private void FRMReporte5_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();

            if (File.Exists(rutaArchivo))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(rutaArchivo);

                // Asegúrate de que el nombre de la tabla en el XML sea "TBL_Productos"
                if (ds.Tables.Contains("TBL_Productos"))
                {
                    ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["TBL_Productos"]);
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("La tabla 'TBL_Productos' no se encontró en el archivo XML.", "Advertencia");
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo Productos.xml.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }     
    }
}
