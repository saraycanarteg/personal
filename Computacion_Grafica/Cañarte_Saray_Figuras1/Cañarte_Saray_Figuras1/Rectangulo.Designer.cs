namespace Practica1_graphics
{
    partial class Rectangulo
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
            this.btncalculo = new System.Windows.Forms.Button();
            this.lblb = new System.Windows.Forms.Label();
            this.lblh = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalculo
            // 
            this.btncalculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculo.ForeColor = System.Drawing.SystemColors.Control;
            this.btncalculo.Location = new System.Drawing.Point(399, 261);
            this.btncalculo.Name = "btncalculo";
            this.btncalculo.Size = new System.Drawing.Size(112, 32);
            this.btncalculo.TabIndex = 0;
            this.btncalculo.Text = "Calcular";
            this.btncalculo.UseVisualStyleBackColor = false;
            this.btncalculo.Click += new System.EventHandler(this.btncalculo_Click);
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(259, 148);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(166, 16);
            this.lblb.TabIndex = 1;
            this.lblb.Text = "Ingrese el valor de la base";
            // 
            // lblh
            // 
            this.lblh.AutoSize = true;
            this.lblh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblh.Location = new System.Drawing.Point(259, 187);
            this.lblh.Name = "lblh";
            this.lblh.Size = new System.Drawing.Size(168, 16);
            this.lblh.TabIndex = 2;
            this.lblh.Text = "Ingrese el valor de la altura";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(523, 147);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 20);
            this.txtbase.TabIndex = 3;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(523, 183);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(228, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(425, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "-ˋˏ ༻ RECTÁNGULO ༺ ˎˊ-";
            // 
            // Rectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.lblh);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.btncalculo);
            this.Name = "Rectangulo";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Rectangulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculo;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblh;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label label5;
    }
}