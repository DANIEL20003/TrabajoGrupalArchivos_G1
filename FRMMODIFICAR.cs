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
    public partial class FRMMODIFICAR : Form

    {

        string nombre, dist;
        double precio;
        int stock, codigo;

        System.Data.DataRow[] vectRow, vectNew;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //aqui edite donde decia verdura para que se pueda usar para cualquier producto desde la tabla TBl_Productos
                codigo = Convert.ToInt32(txtCod.Text.Trim());
                vectRow = dataSet11.TBL_Productos.Select("codigover =" + codigo.ToString());

                if (vectRow.Length > 0)
                {
                    panel2.Visible = true;
                    txtNombre.Text = vectRow[0]["nombre"].ToString();
                    txtDist.Text = vectRow[0]["distribuidora"].ToString();
                    txtPrecio.Text = vectRow[0]["precio"].ToString();
                    nudStock.Value = Convert.ToInt32(vectRow[0]["stock"].ToString());
                    txtNombre.Focus();
                }
                else throw new Exception("No se ha encontrado el código de la verdura");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error del tipo: {ex.Message}", "Se presentó un error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCod.Clear();
                txtCod.Focus();
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMMODIFICAR_Load(object sender, EventArgs e)
        {
            txtCod.Focus();
            string ruta = AppDomain.CurrentDomain.BaseDirectory;

            dataSet11.ReadXml(Path.Combine(ruta, "Productos.xml"));
            panel2.Visible = false;

            /*
                //modificar la ruts if (File.Exists(rutaArchivo))
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
            */
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory;
                dataSet11.WriteXml(Path.Combine(ruta, "Inventario.xml"));
                lbNoti.Text = "¡Cambios guardados correctamente!";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios: {ex.Message}");
            }
        }

        public FRMMODIFICAR()
        {
            InitializeComponent();
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnBuscar_Click(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = txtNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre no puede estar vacío");

                dist = txtDist.Text.Trim();
                if (string.IsNullOrWhiteSpace(dist)) throw new Exception("La distribuidora no puede estar vacía");

                precio = double.Parse(txtPrecio.Text.Trim());
                if (precio <= 0) throw new Exception("El precio no puede ser menor o igual a 0");

                stock = Convert.ToInt32(nudStock.Value);
                if (stock < 0) throw new Exception("El stock no puede ser menor a 0");

                vectRow[0]["nombre"] = nombre;
                vectRow[0]["distribuidora"] = dist;
                vectRow[0]["precio"] = precio;
                vectRow[0]["stock"] = stock;

                vectRow[0].AcceptChanges();
                string ruta = AppDomain.CurrentDomain.BaseDirectory;
                dataSet11.WriteXml(Path.Combine(ruta, "Inventario.xml"));
                lbNoti.Text = $"¡¡Verdura {vectRow[0]["codigover"]}, editada con éxito!!";
                txtCod.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error del tipo: {ex.Message}");

            }
        }

    }


}

   

       
    

