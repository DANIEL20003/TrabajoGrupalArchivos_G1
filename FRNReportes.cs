using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppArchivosGrupo1
{
    public partial class FRNReportes : Form
    {
        public FRNReportes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reporte6_Click(object sender, EventArgs e)
        {
            FRNreporte6 objtr6 = new FRNreporte6();
            objtr6.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reporte3_Click(object sender, EventArgs e)
        {
            FRMReporte3 objtr3 = new FRMReporte3();
            objtr3.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reporte5_Click(object sender, EventArgs e)
        {
            FRMReporte5 fRMReporte5 = new FRMReporte5();
            fRMReporte5.ShowDialog();
        }

        private void Reporte2_Click(object sender, EventArgs e)
        {
            FRMReporte2 objReporte2 = new FRMReporte2();
            objReporte2.ShowDialog();
        }

        private void Reporte7_Click(object sender, EventArgs e)
        {
            FRMReporte7 fRMReporte7 = new FRMReporte7();
            fRMReporte7.ShowDialog();
        }

        private void Reporte4_Click(object sender, EventArgs e)
        {
            FRMReporte4 fRMReporte4 = new FRMReporte4();
            fRMReporte4.ShowDialog();
        }

        private void Reporte8_Click(object sender, EventArgs e)
        {
            FRMreporte8 objReporte8 = new FRMreporte8();
            objReporte8.ShowDialog();
        }

        private void Reporte1_Click(object sender, EventArgs e)
        {
            FRMReporte1 objReporte1 = new FRMReporte1();
            objReporte1.ShowDialog();
        }

        private void Reporte4_Click_1(object sender, EventArgs e)
        {
            FRMReporte4 objReporte4 = new FRMReporte4();
            objReporte4.ShowDialog();
        }
    }
}
