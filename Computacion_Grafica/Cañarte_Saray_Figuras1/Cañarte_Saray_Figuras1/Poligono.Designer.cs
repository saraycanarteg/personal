namespace Practica1_graphics
{
    partial class Poligono
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtapotema = new System.Windows.Forms.TextBox();
            this.txtlado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumlad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btncalcular.Location = new System.Drawing.Point(391, 299);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(112, 32);
            this.btncalcular.TabIndex = 24;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(245, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 39);
            this.label5.TabIndex = 23;
            this.label5.Text = "-ˋˏ ༻ POLÍGONO ༺ ˎˊ-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ingrese el valor del apotema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ingrese el valor del lado";
            // 
            // txtapotema
            // 
            this.txtapotema.Location = new System.Drawing.Point(481, 137);
            this.txtapotema.Name = "txtapotema";
            this.txtapotema.Size = new System.Drawing.Size(100, 20);
            this.txtapotema.TabIndex = 27;
            // 
            // txtlado
            // 
            this.txtlado.Location = new System.Drawing.Point(481, 185);
            this.txtlado.Name = "txtlado";
            this.txtlado.Size = new System.Drawing.Size(100, 20);
            this.txtlado.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ingrese número de lados";
            // 
            // txtnumlad
            // 
            this.txtnumlad.Location = new System.Drawing.Point(481, 235);
            this.txtnumlad.Name = "txtnumlad";
            this.txtnumlad.Size = new System.Drawing.Size(100, 20);
            this.txtnumlad.TabIndex = 30;
            // 
            // Poligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnumlad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlado);
            this.Controls.Add(this.txtapotema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label5);
            this.Name = "Poligono";
            this.Text = "Poligono";
            this.Load += new System.EventHandler(this.Poligono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtapotema;
        private System.Windows.Forms.TextBox txtlado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumlad;
    }
}