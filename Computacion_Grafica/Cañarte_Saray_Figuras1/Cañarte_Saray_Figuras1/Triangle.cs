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
    public partial class Triangle : Form
    {
        private static Triangle instancia = null;

        public static Triangle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new Triangle();
                return instancia;
            }
        }
        public Triangle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            try
            {
                int basee = int.Parse(txtbase.Text);
                int altura = int.Parse(txtaltura.Text);
                int lado1 = int.Parse(txtlado1.Text);
                int lado2 = int.Parse(txtlado2.Text);

                if (lado1 <= 0 || basee <= 0 || lado2 <= 0 || altura <= 0)
                {
                    MessageBox.Show("Los valores deben ser mayores que cero.");
                    return;
                }
                int area = (basee*altura)/2;
                int perimetro = basee + lado1+lado2;
                MessageBox.Show("Los resultados son \n✩ Área: " + area + "\n✩ Perímetro: " + perimetro);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un formato adecuado de números");
            }
        }

        private void Triangle_Load(object sender, EventArgs e)
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
