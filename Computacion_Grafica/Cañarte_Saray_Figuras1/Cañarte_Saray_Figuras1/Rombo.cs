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
    public partial class Rombo : Form
    {
        private static Rombo instancia = null;

        public static Rombo Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new Rombo();
                return instancia;
            }
        }
        public Rombo()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            try
            {
                int diagmayor = int.Parse(txtdmay.Text);
                int diagmenor = int.Parse(txtdiagmen.Text);
                int lado = int.Parse(txtlado.Text);
                
                if (lado <= 0 || diagmayor<= 0 || diagmenor <= 0)
                {
                    MessageBox.Show("Los valores deben ser mayores que cero.");
                    return;
                }
                if ( diagmayor <= diagmenor)
                {
                    MessageBox.Show("Asegurate que la diagonal mayor sea un valor superior al de la diagonal menor.");
                    return;
                }
                int area = (diagmayor * diagmenor) / 2;
                int perimetro = lado *4;
                MessageBox.Show("Los resultados son \n✩ Área: " + area + "\n✩ Perímetro: " + perimetro);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un formato adecuado de números");
            }
        }

        private void Rombo_Load(object sender, EventArgs e)
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
