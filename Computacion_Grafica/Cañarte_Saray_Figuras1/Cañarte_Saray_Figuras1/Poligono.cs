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
    public partial class Poligono : Form
    {
        private static Poligono instancia = null;

        public static Poligono Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new Poligono();
                return instancia;
            }
        }
        public Poligono()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float apotema = float.Parse(txtapotema.Text);
                float lado = float.Parse(txtlado.Text);
                int numlado = int.Parse(txtnumlad.Text);

                if (lado <= 0 || apotema <= 0 || numlado <= 0)
                {
                    MessageBox.Show("El valor debe ser mayor que cero.");
                    return;
                }
                if (numlado < 5)
                {
                    MessageBox.Show("El número de lados debe ser mayor o igual a 5.");
                    return;
                }
                float perimetro = numlado * lado;
                float area = (perimetro * apotema)/2;
                MessageBox.Show("Los resultados son \n✩ Área: " + area + "\n✩ Perímetro: " + perimetro);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un formato adecuado de números");
            }
        }

        private void Poligono_Load(object sender, EventArgs e)
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
