namespace Practica1_graphics
{
    partial class Triangle
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
            this.lblb = new System.Windows.Forms.Label();
            this.lblh = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtlado1 = new System.Windows.Forms.TextBox();
            this.txtlado2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(311, 145);
            this.lblb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(100, 16);
            this.lblb.TabIndex = 0;
            this.lblb.Text = "Ingrese la base";
            // 
            // lblh
            // 
            this.lblh.AutoSize = true;
            this.lblh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblh.Location = new System.Drawing.Point(307, 197);
            this.lblh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblh.Name = "lblh";
            this.lblh.Size = new System.Drawing.Size(105, 16);
            this.lblh.TabIndex = 1;
            this.lblh.Text = "Ingrese la altura ";
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.ForeColor = System.Drawing.SystemColors.Control;
            this.btncalc.Location = new System.Drawing.Point(481, 346);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(112, 32);
            this.btncalc.TabIndex = 2;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese los lados restantes (exceptuando la base)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(623, 142);
            this.txtbase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(132, 22);
            this.txtbase.TabIndex = 4;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(623, 194);
            this.txtaltura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(132, 22);
            this.txtaltura.TabIndex = 5;
            // 
            // txtlado1
            // 
            this.txtlado1.Location = new System.Drawing.Point(623, 251);
            this.txtlado1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlado1.Name = "txtlado1";
            this.txtlado1.Size = new System.Drawing.Size(132, 22);
            this.txtlado1.TabIndex = 6;
            // 
            // txtlado2
            // 
            this.txtlado2.Location = new System.Drawing.Point(623, 283);
            this.txtlado2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlado2.Name = "txtlado2";
            this.txtlado2.Size = new System.Drawing.Size(132, 22);
            this.txtlado2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "(1)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "(2)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(332, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 39);
            this.label4.TabIndex = 33;
            this.label4.Text = "-ˋˏ ༻ TRIÁNGULO༺ ˎˊ-";
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlado2);
            this.Controls.Add(this.txtlado1);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.lblh);
            this.Controls.Add(this.lblb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Triangle";
            this.Text = "Triangle";
            this.Load += new System.EventHandler(this.Triangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblh;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtlado1;
        private System.Windows.Forms.TextBox txtlado2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}