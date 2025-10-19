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
    public partial class Cuadrado : Form
    {
        private static Cuadrado instancia = null;

        public static Cuadrado Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new Cuadrado();
                return instancia;
            }
        }

        public Cuadrado()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int lado= int.Parse(txtcuadrado.Text);
              
                if (lado <= 0)
                {
                    MessageBox.Show("El valor debe ser mayor que cero.");
                    return;
                }
                int area =  lado * lado;
                int perimetro = 4 * lado;
                MessageBox.Show("Los resultados son \n✩ Área: " + area + "\n✩ Perímetro: " + perimetro);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un formato adecuado de números");
            }
        }

        private void Cuadrado_Load(object sender, EventArgs e)
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
