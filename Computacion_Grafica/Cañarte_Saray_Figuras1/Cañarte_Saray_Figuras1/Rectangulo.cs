using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_graphics
{
    public partial class Rectangulo : Form
    {
        private static Rectangulo instancia = null;

        public static Rectangulo Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new Rectangulo();
                return instancia;
            }
        }
        public Rectangulo()
        {
            InitializeComponent();
        }

        private void btncalculo_Click(object sender, EventArgs e)
        {

            try
            {
                int altura = int.Parse(txtaltura.Text);
                int basee = int.Parse(txtbase.Text);
                if (altura <= 0 || basee <= 0)
                {
                    MessageBox.Show("Los valores deben ser mayores que cero.");
                    return; 
                }
                int area = altura * basee;
                int perimetro = (2 * altura) + (2 * basee);
                MessageBox.Show("Los resultados son \n✩ Área: " + area + "\n✩ Perímetro: " + perimetro);
            }catch (FormatException){
                MessageBox.Show("Ingresa un formato adecuado de números");
            }
        }

        private void Rectangulo_Load(object sender, EventArgs e)
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
