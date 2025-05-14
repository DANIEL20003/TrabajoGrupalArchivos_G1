namespace WinAppArchivosGrupo1
{
    partial class FRMINGRESOPRODUCTO
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TXT_codigo = new System.Windows.Forms.TextBox();
            this.TXT_precio = new System.Windows.Forms.TextBox();
            this.TXT_proveedor = new System.Windows.Forms.TextBox();
            this.TXT_stock = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_descript = new System.Windows.Forms.TextBox();
            this.BTN_Ingresar = new System.Windows.Forms.Button();
            this.CMB_tipo = new System.Windows.Forms.ComboBox();
            this.CMB_color = new System.Windows.Forms.ComboBox();
            this.CMB_volumen = new System.Windows.Forms.ComboBox();
            this.CMB_marca = new System.Windows.Forms.ComboBox();
            this.CMB_material = new System.Windows.Forms.ComboBox();
            this.CMB_unit_venta = new System.Windows.Forms.ComboBox();
            this.dataSet11 = new WinAppArchivosGrupo1.DataSet1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WinAppArchivosGrupo1.Properties.Resources.retroceder1;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(217, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingreso de Producto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 41);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Volumen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Proveedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Marca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(528, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Material:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(654, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Unidad de Venta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "Descripción:";
            // 
            // TXT_codigo
            // 
            this.TXT_codigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_codigo.Location = new System.Drawing.Point(82, 113);
            this.TXT_codigo.Name = "TXT_codigo";
            this.TXT_codigo.Size = new System.Drawing.Size(106, 26);
            this.TXT_codigo.TabIndex = 13;
            this.TXT_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_codigo_KeyPress);
            // 
            // TXT_precio
            // 
            this.TXT_precio.Enabled = false;
            this.TXT_precio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_precio.Location = new System.Drawing.Point(265, 113);
            this.TXT_precio.Name = "TXT_precio";
            this.TXT_precio.Size = new System.Drawing.Size(106, 26);
            this.TXT_precio.TabIndex = 16;
            this.TXT_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_precio_KeyPress);
            // 
            // TXT_proveedor
            // 
            this.TXT_proveedor.Enabled = false;
            this.TXT_proveedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_proveedor.Location = new System.Drawing.Point(480, 113);
            this.TXT_proveedor.Name = "TXT_proveedor";
            this.TXT_proveedor.Size = new System.Drawing.Size(121, 26);
            this.TXT_proveedor.TabIndex = 19;
            this.TXT_proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_proveedor_KeyPress);
            // 
            // TXT_stock
            // 
            this.TXT_stock.Enabled = false;
            this.TXT_stock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_stock.Location = new System.Drawing.Point(681, 113);
            this.TXT_stock.Name = "TXT_stock";
            this.TXT_stock.Size = new System.Drawing.Size(97, 26);
            this.TXT_stock.TabIndex = 24;
            this.TXT_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_stock_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(623, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Stock:";
            // 
            // TXT_descript
            // 
            this.TXT_descript.Enabled = false;
            this.TXT_descript.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_descript.Location = new System.Drawing.Point(26, 312);
            this.TXT_descript.Multiline = true;
            this.TXT_descript.Name = "TXT_descript";
            this.TXT_descript.Size = new System.Drawing.Size(451, 72);
            this.TXT_descript.TabIndex = 25;
            // 
            // BTN_Ingresar
            // 
            this.BTN_Ingresar.BackColor = System.Drawing.Color.Pink;
            this.BTN_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ingresar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ingresar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Ingresar.Location = new System.Drawing.Point(650, 333);
            this.BTN_Ingresar.Name = "BTN_Ingresar";
            this.BTN_Ingresar.Size = new System.Drawing.Size(128, 35);
            this.BTN_Ingresar.TabIndex = 26;
            this.BTN_Ingresar.Text = "Ingresar";
            this.BTN_Ingresar.UseVisualStyleBackColor = false;
            this.BTN_Ingresar.Click += new System.EventHandler(this.BTN_Ingresar_Click);
            // 
            // CMB_tipo
            // 
            this.CMB_tipo.Enabled = false;
            this.CMB_tipo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_tipo.FormattingEnabled = true;
            this.CMB_tipo.Items.AddRange(new object[] {
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
            this.CMB_tipo.Location = new System.Drawing.Point(19, 177);
            this.CMB_tipo.Name = "CMB_tipo";
            this.CMB_tipo.Size = new System.Drawing.Size(133, 27);
            this.CMB_tipo.TabIndex = 27;
            // 
            // CMB_color
            // 
            this.CMB_color.Enabled = false;
            this.CMB_color.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_color.FormattingEnabled = true;
            this.CMB_color.Items.AddRange(new object[] {
            "Azul",
            "Rojo",
            "Verde",
            "Negro",
            "Amarillo",
            "Rosa",
            "Morado",
            "Blanco",
            "Gris",
            "Multicolor"});
            this.CMB_color.Location = new System.Drawing.Point(168, 177);
            this.CMB_color.Name = "CMB_color";
            this.CMB_color.Size = new System.Drawing.Size(89, 27);
            this.CMB_color.TabIndex = 28;
            // 
            // CMB_volumen
            // 
            this.CMB_volumen.Enabled = false;
            this.CMB_volumen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_volumen.FormattingEnabled = true;
            this.CMB_volumen.Items.AddRange(new object[] {
            "Pequeño",
            "Mediano",
            "Grande",
            "Extra Grande"});
            this.CMB_volumen.Location = new System.Drawing.Point(274, 177);
            this.CMB_volumen.Name = "CMB_volumen";
            this.CMB_volumen.Size = new System.Drawing.Size(112, 27);
            this.CMB_volumen.TabIndex = 29;
            // 
            // CMB_marca
            // 
            this.CMB_marca.Enabled = false;
            this.CMB_marca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_marca.FormattingEnabled = true;
            this.CMB_marca.Items.AddRange(new object[] {
            "Bic",
            "Faber-Castell",
            "Pelikan",
            "Stabilo",
            "Pilot",
            "Maped",
            "Staedtler",
            "Artesco",
            "Norma",
            "Milan"});
            this.CMB_marca.Location = new System.Drawing.Point(400, 177);
            this.CMB_marca.Name = "CMB_marca";
            this.CMB_marca.Size = new System.Drawing.Size(115, 27);
            this.CMB_marca.TabIndex = 30;
            // 
            // CMB_material
            // 
            this.CMB_material.Enabled = false;
            this.CMB_material.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_material.FormattingEnabled = true;
            this.CMB_material.Items.AddRange(new object[] {
            "Plástico",
            "Metal",
            "Madera",
            "Papel/Cartón",
            "Tela",
            "Goma"});
            this.CMB_material.Location = new System.Drawing.Point(532, 177);
            this.CMB_material.Name = "CMB_material";
            this.CMB_material.Size = new System.Drawing.Size(110, 27);
            this.CMB_material.TabIndex = 31;
            // 
            // CMB_unit_venta
            // 
            this.CMB_unit_venta.Enabled = false;
            this.CMB_unit_venta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_unit_venta.FormattingEnabled = true;
            this.CMB_unit_venta.Items.AddRange(new object[] {
            "Unidad",
            "Docena",
            "Paquete",
            "Caja"});
            this.CMB_unit_venta.Location = new System.Drawing.Point(658, 177);
            this.CMB_unit_venta.Name = "CMB_unit_venta";
            this.CMB_unit_venta.Size = new System.Drawing.Size(120, 27);
            this.CMB_unit_venta.TabIndex = 32;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FRMINGRESOPRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.CMB_unit_venta);
            this.Controls.Add(this.CMB_material);
            this.Controls.Add(this.CMB_marca);
            this.Controls.Add(this.CMB_volumen);
            this.Controls.Add(this.CMB_color);
            this.Controls.Add(this.CMB_tipo);
            this.Controls.Add(this.BTN_Ingresar);
            this.Controls.Add(this.TXT_descript);
            this.Controls.Add(this.TXT_stock);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXT_proveedor);
            this.Controls.Add(this.TXT_precio);
            this.Controls.Add(this.TXT_codigo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FRMINGRESOPRODUCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMINGRESOPRODUCTO";
            this.Load += new System.EventHandler(this.FRMINGRESOPRODUCTO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXT_codigo;
        private System.Windows.Forms.TextBox TXT_precio;
        private System.Windows.Forms.TextBox TXT_proveedor;
        private System.Windows.Forms.TextBox TXT_stock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXT_descript;
        private System.Windows.Forms.Button BTN_Ingresar;
        private DataSet1 dataSet11;
        private System.Windows.Forms.ComboBox CMB_tipo;
        private System.Windows.Forms.ComboBox CMB_color;
        private System.Windows.Forms.ComboBox CMB_volumen;
        private System.Windows.Forms.ComboBox CMB_marca;
        private System.Windows.Forms.ComboBox CMB_material;
        private System.Windows.Forms.ComboBox CMB_unit_venta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}