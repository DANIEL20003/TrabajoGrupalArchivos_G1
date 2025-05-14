namespace WinAppArchivosGrupo1
{
    partial class FormBusqueda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PNL_BuscarProductos = new System.Windows.Forms.Panel();
            this.LBL_titulo = new System.Windows.Forms.Label();
            this.DGV_1 = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WinAppArchivosGrupo1.DataSet1();
            this.LBL_txtcodigo = new System.Windows.Forms.Label();
            this.TB_codigo = new System.Windows.Forms.TextBox();
            this.LBL_txttipo = new System.Windows.Forms.Label();
            this.BTN_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RB_codigo = new System.Windows.Forms.RadioButton();
            this.RB_tipo = new System.Windows.Forms.RadioButton();
            this.CB_tipo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PNL_BuscarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_BuscarProductos
            // 
            this.PNL_BuscarProductos.BackColor = System.Drawing.Color.Pink;
            this.PNL_BuscarProductos.Controls.Add(this.pictureBox1);
            this.PNL_BuscarProductos.Controls.Add(this.LBL_titulo);
            this.PNL_BuscarProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_BuscarProductos.Location = new System.Drawing.Point(0, 0);
            this.PNL_BuscarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PNL_BuscarProductos.Name = "PNL_BuscarProductos";
            this.PNL_BuscarProductos.Size = new System.Drawing.Size(1412, 108);
            this.PNL_BuscarProductos.TabIndex = 0;
            // 
            // LBL_titulo
            // 
            this.LBL_titulo.AutoSize = true;
            this.LBL_titulo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titulo.ForeColor = System.Drawing.Color.Black;
            this.LBL_titulo.Location = new System.Drawing.Point(148, 29);
            this.LBL_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_titulo.Name = "LBL_titulo";
            this.LBL_titulo.Size = new System.Drawing.Size(623, 51);
            this.LBL_titulo.TabIndex = 0;
            this.LBL_titulo.Text = "BÚSQUEDA DE PRODUCTOS";
            // 
            // DGV_1
            // 
            this.DGV_1.AutoGenerateColumns = false;
            this.DGV_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.volumenDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.unidadVentaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.DGV_1.DataMember = "TBL_Productos";
            this.DGV_1.DataSource = this.dataSet1BindingSource;
            this.DGV_1.Location = new System.Drawing.Point(32, 275);
            this.DGV_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_1.Name = "DGV_1";
            this.DGV_1.RowHeadersWidth = 51;
            this.DGV_1.Size = new System.Drawing.Size(1347, 274);
            this.DGV_1.TabIndex = 1;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // volumenDataGridViewTextBoxColumn
            // 
            this.volumenDataGridViewTextBoxColumn.DataPropertyName = "Volumen";
            this.volumenDataGridViewTextBoxColumn.HeaderText = "Volumen";
            this.volumenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.volumenDataGridViewTextBoxColumn.Name = "volumenDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // unidadVentaDataGridViewTextBoxColumn
            // 
            this.unidadVentaDataGridViewTextBoxColumn.DataPropertyName = "Unidad_Venta";
            this.unidadVentaDataGridViewTextBoxColumn.HeaderText = "Unidad_Venta";
            this.unidadVentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadVentaDataGridViewTextBoxColumn.Name = "unidadVentaDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LBL_txtcodigo
            // 
            this.LBL_txtcodigo.AutoSize = true;
            this.LBL_txtcodigo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_txtcodigo.Location = new System.Drawing.Point(489, 172);
            this.LBL_txtcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_txtcodigo.Name = "LBL_txtcodigo";
            this.LBL_txtcodigo.Size = new System.Drawing.Size(91, 25);
            this.LBL_txtcodigo.TabIndex = 2;
            this.LBL_txtcodigo.Text = "Código:";
            this.LBL_txtcodigo.Visible = false;
            // 
            // TB_codigo
            // 
            this.TB_codigo.Location = new System.Drawing.Point(494, 208);
            this.TB_codigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_codigo.Name = "TB_codigo";
            this.TB_codigo.Size = new System.Drawing.Size(265, 26);
            this.TB_codigo.TabIndex = 3;
            this.TB_codigo.Visible = false;
            this.TB_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_codigo_KeyPress);
            // 
            // LBL_txttipo
            // 
            this.LBL_txttipo.AutoSize = true;
            this.LBL_txttipo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_txttipo.Location = new System.Drawing.Point(489, 172);
            this.LBL_txttipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_txttipo.Name = "LBL_txttipo";
            this.LBL_txttipo.Size = new System.Drawing.Size(65, 25);
            this.LBL_txttipo.TabIndex = 4;
            this.LBL_txttipo.Text = "Tipo:";
            this.LBL_txttipo.Visible = false;
            // 
            // BTN_buscar
            // 
            this.BTN_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_buscar.FlatAppearance.BorderSize = 0;
            this.BTN_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_buscar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_buscar.ForeColor = System.Drawing.Color.Black;
            this.BTN_buscar.Location = new System.Drawing.Point(801, 208);
            this.BTN_buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_buscar.Name = "BTN_buscar";
            this.BTN_buscar.Size = new System.Drawing.Size(122, 31);
            this.BTN_buscar.TabIndex = 6;
            this.BTN_buscar.Text = "BUSCAR";
            this.BTN_buscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Realizar busqueda por:";
            // 
            // RB_codigo
            // 
            this.RB_codigo.AutoSize = true;
            this.RB_codigo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_codigo.Location = new System.Drawing.Point(46, 208);
            this.RB_codigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_codigo.Name = "RB_codigo";
            this.RB_codigo.Size = new System.Drawing.Size(97, 25);
            this.RB_codigo.TabIndex = 8;
            this.RB_codigo.TabStop = true;
            this.RB_codigo.Text = "Código";
            this.RB_codigo.UseVisualStyleBackColor = true;
            // 
            // RB_tipo
            // 
            this.RB_tipo.AutoSize = true;
            this.RB_tipo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_tipo.Location = new System.Drawing.Point(196, 208);
            this.RB_tipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_tipo.Name = "RB_tipo";
            this.RB_tipo.Size = new System.Drawing.Size(69, 25);
            this.RB_tipo.TabIndex = 9;
            this.RB_tipo.TabStop = true;
            this.RB_tipo.Text = "Tipo";
            this.RB_tipo.UseVisualStyleBackColor = true;
            // 
            // CB_tipo
            // 
            this.CB_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_tipo.FormattingEnabled = true;
            this.CB_tipo.Items.AddRange(new object[] {
            "Lápices",
            "Bolígrafos",
            "Cuadernos",
            "Gomas de borrar",
            "Sacapuntas",
            "Reglas",
            "Tijeras",
            "Pegamento",
            "Mochilas",
            "Estuches",
            "Rotuladores",
            "Compás"});
            this.CB_tipo.Location = new System.Drawing.Point(494, 209);
            this.CB_tipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_tipo.Name = "CB_tipo";
            this.CB_tipo.Size = new System.Drawing.Size(265, 28);
            this.CB_tipo.TabIndex = 10;
            this.CB_tipo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppArchivosGrupo1.Properties.Resources.retroceder;
            this.pictureBox1.Location = new System.Drawing.Point(13, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1412, 617);
            this.Controls.Add(this.CB_tipo);
            this.Controls.Add(this.RB_tipo);
            this.Controls.Add(this.RB_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_buscar);
            this.Controls.Add(this.LBL_txttipo);
            this.Controls.Add(this.TB_codigo);
            this.Controls.Add(this.LBL_txtcodigo);
            this.Controls.Add(this.DGV_1);
            this.Controls.Add(this.PNL_BuscarProductos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBusqueda";
            this.Text = "FormBusqueda";
            this.Load += new System.EventHandler(this.FormBusqueda_Load);
            this.PNL_BuscarProductos.ResumeLayout(false);
            this.PNL_BuscarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_BuscarProductos;
        private System.Windows.Forms.Label LBL_titulo;
        private System.Windows.Forms.DataGridView DGV_1;
        private System.Windows.Forms.Label LBL_txtcodigo;
        private System.Windows.Forms.TextBox TB_codigo;
        private System.Windows.Forms.Label LBL_txttipo;
        private System.Windows.Forms.Button BTN_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RB_codigo;
        private System.Windows.Forms.RadioButton RB_tipo;
        private System.Windows.Forms.ComboBox CB_tipo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}