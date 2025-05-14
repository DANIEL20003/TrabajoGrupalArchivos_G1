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
    public partial class FRMINGRESOPRODUCTO : Form
    {
        string codigo, provedor;
        int stock;
        double precio;
        
        public FRMINGRESOPRODUCTO()
        {
            InitializeComponent();
        }

        private void FRMINGRESOPRODUCTO_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TXT_codigo;
        }

        private void TXT_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Enter)
            {
                try
                {
                    codigo = TXT_codigo.Text;
                    TXT_precio.Enabled = true;
                    TXT_precio.Focus();

                }
                catch
                {
                    MessageBox.Show("Ingrese un código valido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXT_codigo.Clear();
                }
            }
        }

        private void TXT_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    precio = double.Parse(TXT_precio.Text);
                    
                    if (precio > 0)
                    {
                        TXT_proveedor.Enabled = true;
                        TXT_proveedor.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un precio valido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_precio.Clear();
                    }

                }
                catch
                {
                    MessageBox.Show("Ingrese un valor numérico.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXT_precio.Clear();
                }
            }
        }

        private void TXT_proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    provedor = TXT_proveedor.Text;

                    TXT_stock.Enabled = true;
                    TXT_stock.Focus();

                }
                catch
                {
                    MessageBox.Show("Ingrese un proveedor valido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXT_proveedor.Clear();
                }
            }
        }

        private void TXT_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    stock = int.Parse(TXT_stock.Text);

                    if (stock >= 0)
                    {
                        CMB_tipo.Enabled = true;
                        CMB_color.Enabled = true;
                        CMB_volumen.Enabled = true;
                        CMB_marca.Enabled = true;
                        CMB_material.Enabled = true;
                        CMB_unit_venta.Enabled = true;
                        TXT_descript.Enabled = true;
                        TXT_descript.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad validad.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_stock.Clear();
                    }

                }
                catch
                {
                    MessageBox.Show("Ingrese un número entero.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXT_stock.Clear();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Ingresar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos obligatorios estén completos
            if (string.IsNullOrWhiteSpace(TXT_codigo.Text) ||
                string.IsNullOrWhiteSpace(TXT_precio.Text) ||
                string.IsNullOrWhiteSpace(TXT_proveedor.Text) ||
                string.IsNullOrWhiteSpace(TXT_stock.Text) ||
                CMB_tipo.SelectedIndex == -1 ||  // ComboBox no seleccionado
                CMB_color.SelectedIndex == -1 ||
                CMB_volumen.SelectedIndex == -1 ||
                CMB_marca.SelectedIndex == -1 ||
                CMB_material.SelectedIndex == -1 ||
                CMB_unit_venta.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(TXT_descript.Text))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución si hay campos vacíos
            }

            try
            {
                //Ruta del archivo XML (se guardará en la carpeta del ejecutable)
                //string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Productos.xml");

                // Obtener la ruta del directorio del proyecto (fuera de \bin\Debug)
                string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string rutaResources = Path.Combine(rutaProyecto, "Base_de_Datos");
                string rutaArchivo = Path.Combine(rutaResources, "Productos.xml");

                // Si la carpeta Resources no existe, créala
                if (!Directory.Exists(rutaResources))
                {
                    Directory.CreateDirectory(rutaResources);
                }

                //Verificar si el archivo XML existe
                if (!File.Exists(rutaArchivo))
                {
                    dataSet11.TBL_Productos.Clear();
                    dataSet11.TBL_Productos.WriteXml(rutaArchivo);
                }
                else
                {
                    // Si existe, cargar los datos existentes
                    dataSet11.TBL_Productos.Clear();
                    dataSet11.TBL_Productos.ReadXml(rutaArchivo);
                }

                //Vector con los valores de los campos
                object[] nuevoProducto = new object[11]; // 11 campos en TBL_Productos

                //Valores al vector en el orden de las columnas
                nuevoProducto[0] = codigo;
                nuevoProducto[1] = CMB_tipo.SelectedItem.ToString();
                nuevoProducto[2] = CMB_color.SelectedItem.ToString();
                nuevoProducto[3] = precio;
                nuevoProducto[4] = CMB_volumen.SelectedItem.ToString();
                nuevoProducto[5] = CMB_marca.SelectedItem.ToString();
                nuevoProducto[6] = provedor;
                nuevoProducto[7] = CMB_material.SelectedItem.ToString();
                nuevoProducto[8] = stock;
                nuevoProducto[9] = CMB_unit_venta.SelectedItem.ToString();
                nuevoProducto[10] = TXT_descript.Text;

                //Vector como nueva fila a la tabla
                dataSet11.TBL_Productos.Rows.Add(nuevoProducto);

                //Guardar
                dataSet11.TBL_Productos.WriteXml(rutaArchivo);

                MessageBox.Show("Producto ingresado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ingresar el producto: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
