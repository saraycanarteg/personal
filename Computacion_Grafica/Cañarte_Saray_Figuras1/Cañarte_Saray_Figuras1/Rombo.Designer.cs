namespace Practica1_graphics
{
    partial class Rombo
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlado = new System.Windows.Forms.TextBox();
            this.txtdmay = new System.Windows.Forms.TextBox();
            this.txtdiagmen = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(369, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "-ˋˏ ༻ ROMBO ༺ ˎˊ-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese el valor del lado del rombo";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingrese la diagonal mayor";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingrese la diagonal menor";
           
            // 
            // txtlado
            // 
            this.txtlado.Location = new System.Drawing.Point(600, 146);
            this.txtlado.Margin = new System.Windows.Forms.Padding(4);
            this.txtlado.Name = "txtlado";
            this.txtlado.Size = new System.Drawing.Size(132, 22);
            this.txtlado.TabIndex = 16;
            
            // 
            // txtdmay
            // 
            this.txtdmay.Location = new System.Drawing.Point(600, 188);
            this.txtdmay.Margin = new System.Windows.Forms.Padding(4);
            this.txtdmay.Name = "txtdmay";
            this.txtdmay.Size = new System.Drawing.Size(132, 22);
            this.txtdmay.TabIndex = 17;
            // 
            // txtdiagmen
            // 
            this.txtdiagmen.Location = new System.Drawing.Point(600, 234);
            this.txtdiagmen.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiagmen.Name = "txtdiagmen";
            this.txtdiagmen.Size = new System.Drawing.Size(132, 22);
            this.txtdiagmen.TabIndex = 18;
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.ForeColor = System.Drawing.SystemColors.Control;
            this.btncalc.Location = new System.Drawing.Point(487, 303);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(112, 32);
            this.btncalc.TabIndex = 19;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // Rombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtdiagmen);
            this.Controls.Add(this.txtdmay);
            this.Controls.Add(this.txtlado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rombo";
            this.Text = "Rombo";
            this.Load += new System.EventHandler(this.Rombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlado;
        private System.Windows.Forms.TextBox txtdmay;
        private System.Windows.Forms.TextBox txtdiagmen;
        private System.Windows.Forms.Button btncalc;
    }
}