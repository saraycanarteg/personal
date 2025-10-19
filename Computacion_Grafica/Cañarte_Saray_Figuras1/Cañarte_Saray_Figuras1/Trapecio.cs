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
    public partial class Trapecio : Form
    {
        private static Trapecio instancia = null;

        public static Trapecio Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new Trapecio();
                return instancia;
            }
        }
        public Trapecio()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int bmay = int.Parse(txtbmay.Text);
                int bmen= int.Parse(txtbmen.Text);
                int lado1 = int.Parse(txtlado1.Text);
                int lado2 = int.Parse(txtlado2.Text);
                int altura = int.Parse(txtaltura.Text);


                if (lado1 <= 0 || lado2 <= 0 || bmay <= 0 || bmen<=0 || altura <= 0)
                {
                    MessageBox.Show("Los valores deben ser mayores que cero.");
                    return;
                }
                int area = (altura * (bmay * bmen))/2;
                int perimetro = bmen + bmay +lado1 +lado2;
                MessageBox.Show("Los resultados son \n✩ Área: " + area + "\n✩ Perímetro: " + perimetro);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un formato adecuado de números");
            }
        }

        private void Trapecio_Load(object sender, EventArgs e)
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
