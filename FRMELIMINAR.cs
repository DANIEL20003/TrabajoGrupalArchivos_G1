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
    public partial class FRMELIMINAR : Form
    {

        System.Data.DataRow[] Vector;
        public FRMELIMINAR()
        {
            InitializeComponent();
        }

        private void FRMELIMINAR_Load(object sender, EventArgs e)
        {
            txtCod.Focus();
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string rutaResources = Path.Combine(rutaProyecto, "Base_de_Datos");
            string rutaArchivo = Path.Combine(rutaResources, "Productos.xml");
            dataSet11.ReadXml(rutaArchivo);
            panel2.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Vector = dataSet11.TBL_Productos.Select("Codigo = '" + txtCod.Text + "' ");
                if (Vector.Length > 0)
                {
                    panel2.Visible = true;
                    lblCodigo.Text = Vector[0]["Codigo"].ToString();
                    lblTipo.Text = Vector[0]["Tipo"].ToString();
                    lblColor.Text = Vector[0]["Color"].ToString();
                    lblPrecio.Text = Vector[0]["Precio"].ToString();
                    lblVolumen.Text = Vector[0]["Volumen"].ToString();
                    lblMarca.Text = Vector[0]["Marca"].ToString();
                    lblProveedor.Text = Vector[0]["Proveedor"].ToString();
                    lblMaterial.Text = Vector[0]["Material"].ToString();
                    lblStock.Text = Vector[0]["Stock"].ToString();
                    lblUnidadVenta.Text = Vector[0]["Unidad_Venta"].ToString();
                    lblDescripcion.Text = Vector[0]["Descripcion"].ToString();

                }
                else
                {
                    MessageBox.Show("No existen registros asociados", "No se encontró", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error del tipo: {ex.Message}", "Se presentó un error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCod.Clear();
                txtCod.Focus();
            }
            
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar_Click(sender, e);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se canceló la eliminación", "Operación Cancelada", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Vector[0].Delete();
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string rutaResources = Path.Combine(rutaProyecto, "Base_de_Datos");
            string rutaArchivo = Path.Combine(rutaResources, "Productos.xml");
            dataSet11.WriteXml(rutaArchivo);
            MessageBox.Show("Se ha eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
