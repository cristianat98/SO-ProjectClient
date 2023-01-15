namespace Cliente
{
    partial class Apuesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apuesta));
            this.apostar = new System.Windows.Forms.Button();
            this.texto_apuesta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // apostar
            // 
            this.apostar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apostar.Location = new System.Drawing.Point(135, 238);
            this.apostar.Name = "apostar";
            this.apostar.Size = new System.Drawing.Size(129, 39);
            this.apostar.TabIndex = 0;
            this.apostar.Text = "Apostar";
            this.apostar.UseVisualStyleBackColor = true;
            this.apostar.Click += new System.EventHandler(this.apostar_Click);
            // 
            // texto_apuesta
            // 
            this.texto_apuesta.AutoSize = true;
            this.texto_apuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.texto_apuesta.Location = new System.Drawing.Point(81, 119);
            this.texto_apuesta.Name = "texto_apuesta";
            this.texto_apuesta.Size = new System.Drawing.Size(255, 24);
            this.texto_apuesta.TabIndex = 1;
            this.texto_apuesta.Text = "¿Qué crees que vas a sacar?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 324);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "En estos momentos debes realizar tu apuesta, una apuesta razonable\r\nsobre cuanto " +
    "crees que obtendrás en las cartas. Cuanto más te \r\nacerques más puntos de recomp" +
    "ensa obtendrás. \r\n¿Listo?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Apuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.texto_apuesta);
            this.Controls.Add(this.apostar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Apuesta";
            this.Text = "Apuesta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apostar;
        private System.Windows.Forms.Label texto_apuesta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}