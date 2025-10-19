using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_graphics
{
    public partial class Circulo : Form
    {
        private static Circulo instancia = null;

        public static Circulo Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new Circulo();
                return instancia;
            }
        }
        public Circulo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float radio = float.Parse(txtradio.Text);
   
                if (radio <= 0 )
                {
                    MessageBox.Show("Los valores deben ser mayores que cero.");
                    return;
                }
                float diametro = radio * 2;
                float area = 3.14f * (radio * radio);
                float perimetro = 3.14f * diametro;
                MessageBox.Show("Los resultados son \n✩ Área: " + area + "\n✩ Perímetro: " + perimetro);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un formato adecuado de números");
            }
        }

        private void Circulo_Load(object sender, EventArgs e)
        {
            if (this.MdiParent != null)
            {
                this.Location = new Point(
                    (this.MdiParent.ClientSize.Width - this.Width) / 2,
                    (this.MdiParent.ClientSize.Height - this.Height) / 2
                );
            }
        }
    }
}
