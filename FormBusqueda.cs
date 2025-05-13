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
    public partial class FormBusqueda : Form
    {
        string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Productos.xml");
        public FormBusqueda()
        {
            InitializeComponent();
            // Opcional: inicializa estado
            RB_codigo.Checked = true; // por defecto muestra código

            LBL_txttipo.Visible = false;
            TB_tipo.Visible = false;
        }

        private void TB_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    
                    if (string.IsNullOrWhiteSpace(TB_codigo.Text))
                    {
                        MessageBox.Show("Debe ingresar el código del producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    TB_tipo.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un código para buscar el producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_codigo.Clear();
            }
        }

        private void TB_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (string.IsNullOrWhiteSpace(TB_tipo.Text) || string.IsNullOrWhiteSpace(TB_codigo.Text))
                    {
                        MessageBox.Show("Debe ingresar el código y el tipo del producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cargar el XML al DataSet
                    dataSet1.Clear(); // Limpiar antes de cargar para evitar duplicados
                    dataSet1.ReadXml(rutaArchivo);

                    // Buscar los productos que coincidan con el código y tipo ingresados
                    string filtro = $"Codigo = '{TB_codigo.Text}' AND Tipo = '{TB_tipo.Text}'";
                    DataRow[] productosFiltrados = dataSet1.TBL_Productos.Select(filtro);

                    // Verificar si encontró productos
                    if (productosFiltrados.Length > 0)
                    {
                        // Crear una tabla temporal para mostrar solo los resultados encontrados
                        DataTable tablaResultado = dataSet1.TBL_Productos.Clone(); // copia estructura sin datos
                        foreach (DataRow fila in productosFiltrados)
                        {
                            tablaResultado.ImportRow(fila);
                        }

                        DGV_1.DataSource = tablaResultado; // Mostrar los datos encontrados
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado con ese código y tipo.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DGV_1.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RB_codigo_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_codigo.Checked)
            {
                // Mostrar solo los controles relacionados al código
                LBL_txtcodigo.Visible = true;
                TB_codigo.Visible = true;

                LBL_txttipo.Visible = false;
                TB_tipo.Visible = false;
            }
        }

        private void RB_tipo_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_tipo.Checked)
            {
                // Mostrar solo los controles relacionados al tipo
                LBL_txttipo.Visible = true;
                TB_tipo.Visible = true;

                LBL_txtcodigo.Visible = false;
                TB_codigo.Visible = false;
            }
        }


    }
}
