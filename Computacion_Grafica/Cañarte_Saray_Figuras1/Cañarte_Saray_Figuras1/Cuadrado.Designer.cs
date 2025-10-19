namespace Practica1_graphics
{
    partial class Cuadrado
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
            this.lblcuadrado = new System.Windows.Forms.Label();
            this.txtcuadrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btncalcular.Location = new System.Drawing.Point(372, 209);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(112, 32);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblcuadrado
            // 
            this.lblcuadrado.AutoSize = true;
            this.lblcuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuadrado.Location = new System.Drawing.Point(236, 147);
            this.lblcuadrado.Name = "lblcuadrado";
            this.lblcuadrado.Size = new System.Drawing.Size(237, 16);
            this.lblcuadrado.TabIndex = 1;
            this.lblcuadrado.Text = "Ingrese el valor del lado del cuadrado:";
            // 
            // txtcuadrado
            // 
            this.txtcuadrado.Location = new System.Drawing.Point(492, 144);
            this.txtcuadrado.Name = "txtcuadrado";
            this.txtcuadrado.Size = new System.Drawing.Size(100, 20);
            this.txtcuadrado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(232, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "-ˋˏ ༻ CUADRADO ༺ ˎˊ-";
            // 
            // Cuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcuadrado);
            this.Controls.Add(this.lblcuadrado);
            this.Controls.Add(this.btncalcular);
            this.Name = "Cuadrado";
            this.Text = "cuadrado";
            this.Load += new System.EventHandler(this.Cuadrado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblcuadrado;
        private System.Windows.Forms.TextBox txtcuadrado;
        private System.Windows.Forms.Label label1;
    }
}