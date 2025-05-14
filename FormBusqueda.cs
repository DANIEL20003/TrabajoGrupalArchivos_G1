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
        string rutaArchivo;



        public FormBusqueda()
        {
            InitializeComponent();
            //string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Productos.xml");
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent?.Parent?.FullName;
            string rutaResources = Path.Combine(rutaProyecto, "Base_de_Datos");
            rutaArchivo = Path.Combine(rutaResources, "Productos.xml");

            // Estado inicial: búsqueda por código
            RB_codigo.Checked = true;

            // Mostrar controles solo para código al inicio
            LBL_txtcodigo.Visible = TB_codigo.Visible = true;
            LBL_txttipo.Visible = CB_tipo.Visible = false;

            // Eventos
            RB_codigo.CheckedChanged += RB_codigo_CheckedChanged;
            RB_tipo.CheckedChanged += RB_tipo_CheckedChanged;

            TB_codigo.KeyPress += TB_codigo_KeyPress;
            CB_tipo.KeyPress += CB_tipo_KeyPress;

            BTN_buscar.Click += BTN_buscar_Click;
        }

        private void RB_codigo_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_codigo.Checked)
            {
                LBL_txtcodigo.Visible = TB_codigo.Visible = true;
                LBL_txttipo.Visible = CB_tipo.Visible = false;
                CB_tipo.SelectedIndex = -1; // Limpiar selección
                TB_codigo.Focus();
            }
        }

        private void RB_tipo_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_tipo.Checked)
            {
                LBL_txttipo.Visible = CB_tipo.Visible = true;
                LBL_txtcodigo.Visible = TB_codigo.Visible = false;
                TB_codigo.Clear(); // Limpiar campo
                CB_tipo.Focus();
            }
        }

        private void TB_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (RB_codigo.Checked && e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarProducto();
            }
        }

        private void CB_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (RB_tipo.Checked && e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarProducto();
            }
        }

        private void BTN_buscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void BuscarProducto()
        {
            try
            {
                // Validaciones
                if (RB_codigo.Checked)
                {
                    if (string.IsNullOrWhiteSpace(TB_codigo.Text))
                    {
                        MessageBox.Show("Ingrese el código del producto.", "ERROR",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(CB_tipo.Text))
                    {
                        MessageBox.Show("Seleccione el tipo de producto.", "ERROR",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Leer XML
                dataSet1.Clear();
                dataSet1.ReadXml(rutaArchivo);

                // Filtro
                string filtro;
                if (RB_codigo.Checked)
                    filtro = $"Codigo = '{TB_codigo.Text.Trim()}'";
                else
                    filtro = $"Tipo = '{CB_tipo.Text.Trim()}'";

                // Filtrar filas
                DataRow[] encontrados = dataSet1.TBL_Productos.Select(filtro);

                if (encontrados.Length > 0)
                {
                    DataTable tablaResultado = dataSet1.TBL_Productos.Clone();
                    foreach (DataRow r in encontrados)
                        tablaResultado.ImportRow(r);

                    DGV_1.DataSource = tablaResultado;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos.", "Sin resultados",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormBusqueda_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
