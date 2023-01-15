namespace Cliente
{
    partial class Aceptar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aceptar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aceptarPartida = new System.Windows.Forms.Button();
            this.rechazarPartida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 288);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Has sido invitado a jugar una partida. \r\n                   Aceptas jugar?";
            // 
            // aceptarPartida
            // 
            this.aceptarPartida.BackColor = System.Drawing.Color.LimeGreen;
            this.aceptarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aceptarPartida.Location = new System.Drawing.Point(66, 120);
            this.aceptarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.aceptarPartida.Name = "aceptarPartida";
            this.aceptarPartida.Size = new System.Drawing.Size(241, 48);
            this.aceptarPartida.TabIndex = 8;
            this.aceptarPartida.Text = "Aceptar Partida";
            this.aceptarPartida.UseVisualStyleBackColor = false;
            this.aceptarPartida.Click += new System.EventHandler(this.aceptarPartida_Click);
            // 
            // rechazarPartida
            // 
            this.rechazarPartida.BackColor = System.Drawing.Color.Red;
            this.rechazarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rechazarPartida.Location = new System.Drawing.Point(66, 190);
            this.rechazarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.rechazarPartida.Name = "rechazarPartida";
            this.rechazarPartida.Size = new System.Drawing.Size(241, 48);
            this.rechazarPartida.TabIndex = 7;
            this.rechazarPartida.Text = "Rechazar Partida";
            this.rechazarPartida.UseVisualStyleBackColor = false;
            this.rechazarPartida.Click += new System.EventHandler(this.rechazarPartida_Click);
            // 
            // Aceptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aceptarPartida);
            this.Controls.Add(this.rechazarPartida);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Aceptar";
            this.Text = "Aceptar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Aceptar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aceptarPartida;
        private System.Windows.Forms.Button rechazarPartida;
    }
}