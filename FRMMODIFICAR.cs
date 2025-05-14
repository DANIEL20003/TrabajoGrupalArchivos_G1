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
    public partial class FRMMODIFICAR : Form

    {
        System.Data.DataRow[] Vector;
        string descripcion, dist;
        double precio;
        int stock, codigo;


 
        public FRMMODIFICAR()
        {
            InitializeComponent();
        }

        private void FRMMODIFICAR_Load(object sender, EventArgs e)
        {
            txtCod.Focus();

        
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string rutaResources = Path.Combine(rutaProyecto, "Base_de_Datos");
            string rutaArchivo = Path.Combine(rutaResources, "Productos.xml");

         
            if (File.Exists(rutaArchivo))
            {
                dataSet11.ReadXml(rutaArchivo);
            }
            else
            {
                MessageBox.Show("El archivo Productos.xml no se encuentra en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Vector != null && Vector.Length > 0)
            {
            
                if (!double.TryParse(lblPrecio.Text, out double precioNuevo))
                {
                    MessageBox.Show("El precio debe ser un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblPrecio.Focus();
                    return;
                }
                if (!int.TryParse(lblStock.Text, out int stockNuevo))
                {
                    MessageBox.Show("El stock debe ser un valor numérico entero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblStock.Focus();
                    return;
                }

                Vector[0]["Tipo"] = lblTipo.Text;
                Vector[0]["Color"] = lblColor.Text;
                Vector[0]["Precio"] = precioNuevo;
                Vector[0]["Volumen"] = lblVolumen.Text;
                Vector[0]["Marca"] = lblMarca.Text;
                Vector[0]["Proveedor"] = lblProveedor.Text;
                Vector[0]["Material"] = lblMaterial.Text;
                Vector[0]["Stock"] = stockNuevo;
                Vector[0]["Unidad_Venta"] = lblUnidadVenta.Text;
                Vector[0]["Descripcion"] = lblDescripcion.Text;

                string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string rutaResources = Path.Combine(rutaProyecto, "Base_de_Datos");
                string rutaArchivo = Path.Combine(rutaResources, "Productos.xml");
                dataSet11.WriteXml(rutaArchivo);

                MessageBox.Show("Los cambios se han guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay registro seleccionado para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
          
            txtCod.Clear();
            panel2.Visible = false;

           
            lblCodigo.Text = "";
            lblTipo.Text = "";
            lblColor.Text = "";
            lblPrecio.Text = "";
            lblVolumen.Text = "";
            lblMarca.Text = "";
            lblProveedor.Text = "";
            lblMaterial.Text = "";
            lblStock.Text = "";
            lblUnidadVenta.Text = "";
            lblDescripcion.Text = "";

            txtCod.Focus();
        }

     /*   private void button1_Click(object sender, EventArgs e)
        {
            // Habilitar los campos para edición
            lblTipo.ReadOnly = false;
            lblColor.ReadOnly = false;
            lblPrecio.ReadOnly = false;
            lblVolumen.ReadOnly = false;
            lblMarca.ReadOnly = false;
            lblProveedor.ReadOnly = false;
            lblMaterial.ReadOnly = false;
            lblStock.ReadOnly = false;
            lblUnidadVenta.ReadOnly = false;
            lblDescripcion.ReadOnly = false;

            // Opcional: Dar foco al primer campo editable
            lblTipo.Focus();
        }
     */
        
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar_Click(sender, e);
            }
        }


    }
}


       



   

       
    

