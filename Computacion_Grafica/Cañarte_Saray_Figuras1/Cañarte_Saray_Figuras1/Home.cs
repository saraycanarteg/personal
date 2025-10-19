using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_graphics
{
    public partial class Home : Form
    {
        private void CerrarFormulariosHijos()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        public Home()
        {
            InitializeComponent();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Rectangulo fmrrectangle = Rectangulo.Instancia;
            fmrrectangle.MdiParent = this;
            fmrrectangle.BringToFront();
            fmrrectangle.Show();
        }

        private void homee_Load(object sender, EventArgs e)
        {

        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Cuadrado fmrcuad = Cuadrado.Instancia;
            fmrcuad.MdiParent = this;
            fmrcuad.BringToFront();
            fmrcuad.Show();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Triangle frmtri = Triangle.Instancia;
            frmtri.MdiParent = this;
            frmtri.BringToFront();
            frmtri.Show();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Rombo frmrombo = Rombo.Instancia;
            frmrombo.MdiParent = this;
            frmrombo.BringToFront();
            frmrombo.Show();
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CerrarFormulariosHijos();
            Romboide frmromboide = Romboide.Instancia;      
            frmromboide.MdiParent = this;
            frmromboide.BringToFront();
            frmromboide.Show();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Trapecio frmtrapecio = Trapecio.Instancia;  
            frmtrapecio.MdiParent = this;  
            frmtrapecio.BringToFront();
            frmtrapecio.Show();
        }

        private void ciculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Circulo fmrcirculo = Circulo.Instancia; 
            fmrcirculo.MdiParent = this;
            fmrcirculo.BringToFront();
            fmrcirculo.Show();
        }

        private void poligonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Poligono fmrpoligono = Poligono.Instancia;
            fmrpoligono.MdiParent = this;
            fmrpoligono.BringToFront();
            fmrpoligono.Show();
        }
    }
}
