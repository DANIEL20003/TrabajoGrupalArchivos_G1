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
            this.PNL_BuscarProductos = new System.Windows.Forms.Panel();
            this.LBL_titulo = new System.Windows.Forms.Label();
            this.DGV_1 = new System.Windows.Forms.DataGridView();
            this.LBL_txtcodigo = new System.Windows.Forms.Label();
            this.TB_codigo = new System.Windows.Forms.TextBox();
            this.TB_tipo = new System.Windows.Forms.TextBox();
            this.LBL_txttipo = new System.Windows.Forms.Label();
            this.BTN_buscar = new System.Windows.Forms.Button();
            this.PNL_BuscarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_BuscarProductos
            // 
            this.PNL_BuscarProductos.BackColor = System.Drawing.Color.Pink;
            this.PNL_BuscarProductos.Controls.Add(this.LBL_titulo);
            this.PNL_BuscarProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_BuscarProductos.Location = new System.Drawing.Point(0, 0);
            this.PNL_BuscarProductos.Name = "PNL_BuscarProductos";
            this.PNL_BuscarProductos.Size = new System.Drawing.Size(605, 70);
            this.PNL_BuscarProductos.TabIndex = 0;
            // 
            // LBL_titulo
            // 
            this.LBL_titulo.AutoSize = true;
            this.LBL_titulo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titulo.ForeColor = System.Drawing.Color.Black;
            this.LBL_titulo.Location = new System.Drawing.Point(99, 19);
            this.LBL_titulo.Name = "LBL_titulo";
            this.LBL_titulo.Size = new System.Drawing.Size(407, 32);
            this.LBL_titulo.TabIndex = 0;
            this.LBL_titulo.Text = "BÚSQUEDA DE PRODUCTOS";
            // 
            // DGV_1
            // 
            this.DGV_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_1.Location = new System.Drawing.Point(93, 178);
            this.DGV_1.Name = "DGV_1";
            this.DGV_1.Size = new System.Drawing.Size(393, 178);
            this.DGV_1.TabIndex = 1;
            // 
            // LBL_txtcodigo
            // 
            this.LBL_txtcodigo.AutoSize = true;
            this.LBL_txtcodigo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_txtcodigo.Location = new System.Drawing.Point(52, 100);
            this.LBL_txtcodigo.Name = "LBL_txtcodigo";
            this.LBL_txtcodigo.Size = new System.Drawing.Size(60, 17);
            this.LBL_txtcodigo.TabIndex = 2;
            this.LBL_txtcodigo.Text = "Código:";
            // 
            // TB_codigo
            // 
            this.TB_codigo.Location = new System.Drawing.Point(55, 123);
            this.TB_codigo.Name = "TB_codigo";
            this.TB_codigo.Size = new System.Drawing.Size(178, 20);
            this.TB_codigo.TabIndex = 3;
            // 
            // TB_tipo
            // 
            this.TB_tipo.Location = new System.Drawing.Point(270, 123);
            this.TB_tipo.Name = "TB_tipo";
            this.TB_tipo.Size = new System.Drawing.Size(178, 20);
            this.TB_tipo.TabIndex = 5;
            // 
            // LBL_txttipo
            // 
            this.LBL_txttipo.AutoSize = true;
            this.LBL_txttipo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_txttipo.Location = new System.Drawing.Point(267, 100);
            this.LBL_txttipo.Name = "LBL_txttipo";
            this.LBL_txttipo.Size = new System.Drawing.Size(43, 17);
            this.LBL_txttipo.TabIndex = 4;
            this.LBL_txttipo.Text = "Tipo:";
            // 
            // BTN_buscar
            // 
            this.BTN_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_buscar.FlatAppearance.BorderSize = 0;
            this.BTN_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_buscar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_buscar.ForeColor = System.Drawing.Color.Black;
            this.BTN_buscar.Location = new System.Drawing.Point(478, 110);
            this.BTN_buscar.Name = "BTN_buscar";
            this.BTN_buscar.Size = new System.Drawing.Size(81, 33);
            this.BTN_buscar.TabIndex = 6;
            this.BTN_buscar.Text = "BUSCAR";
            this.BTN_buscar.UseVisualStyleBackColor = false;
            // 
            // FormBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 401);
            this.Controls.Add(this.BTN_buscar);
            this.Controls.Add(this.TB_tipo);
            this.Controls.Add(this.LBL_txttipo);
            this.Controls.Add(this.TB_codigo);
            this.Controls.Add(this.LBL_txtcodigo);
            this.Controls.Add(this.DGV_1);
            this.Controls.Add(this.PNL_BuscarProductos);
            this.Name = "FormBusqueda";
            this.Text = "FormBusqueda";
            this.PNL_BuscarProductos.ResumeLayout(false);
            this.PNL_BuscarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_BuscarProductos;
        private System.Windows.Forms.Label LBL_titulo;
        private System.Windows.Forms.DataGridView DGV_1;
        private System.Windows.Forms.Label LBL_txtcodigo;
        private System.Windows.Forms.TextBox TB_codigo;
        private System.Windows.Forms.TextBox TB_tipo;
        private System.Windows.Forms.Label LBL_txttipo;
        private System.Windows.Forms.Button BTN_buscar;
    }
}