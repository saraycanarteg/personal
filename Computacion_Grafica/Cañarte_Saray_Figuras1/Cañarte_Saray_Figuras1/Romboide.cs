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
    public partial class Romboide : Form
    {
        private static Romboide instancia = null;

        public static Romboide Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new Romboide();
                return instancia;
            }
        }
        public Romboide()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int basee = int.Parse(txtbase.Text);
                int altura = int.Parse(txtaltura.Text);
                int lado = int.Parse(txtlado.Text);

                if (lado <= 0 || basee<= 0 || altura <= 0)
                {
                    MessageBox.Show("Los valores deben ser mayores que cero.");
                    return;
                }
                int area = (basee * altura);
                int perimetro = (2*basee) +(2*lado);
                MessageBox.Show("Los resultados son \n✩ Área: " + area + "\n✩ Perímetro: " + perimetro);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un formato adecuado de números");
            }
        }

        private void Romboide_Load(object sender, EventArgs e)
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
