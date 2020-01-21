namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pasek2 = new System.Windows.Forms.PictureBox();
            this.pasek1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.topLista = new System.Windows.Forms.LinkLabel();
            this.TOP = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pasek3 = new System.Windows.Forms.PictureBox();
            this.pasek4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.przeszkoda3 = new System.Windows.Forms.PictureBox();
            this.przeszkoda2 = new System.Windows.Forms.PictureBox();
            this.przeszkoda1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pasek2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasek1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasek3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasek4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda1)).BeginInit();
            this.SuspendLayout();
            // 
            // pasek2
            // 
            this.pasek2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pasek2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pasek2.BackgroundImage")));
            this.pasek2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pasek2.InitialImage")));
            this.pasek2.Location = new System.Drawing.Point(428, -3);
            this.pasek2.Name = "pasek2";
            this.pasek2.Size = new System.Drawing.Size(11, 82);
            this.pasek2.TabIndex = 11;
            this.pasek2.TabStop = false;
            this.pasek2.Visible = false;
            // 
            // pasek1
            // 
            this.pasek1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pasek1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pasek1.BackgroundImage")));
            this.pasek1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pasek1.InitialImage")));
            this.pasek1.Location = new System.Drawing.Point(428, 147);
            this.pasek1.Name = "pasek1";
            this.pasek1.Size = new System.Drawing.Size(11, 82);
            this.pasek1.TabIndex = 12;
            this.pasek1.TabStop = false;
            this.pasek1.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(428, -3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(165, 262);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.MediumTurquoise;
            this.start.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.SeaGreen;
            this.start.Location = new System.Drawing.Point(464, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(94, 46);
            this.start.TabIndex = 15;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // topLista
            // 
            this.topLista.AutoSize = true;
            this.topLista.BackColor = System.Drawing.Color.OliveDrab;
            this.topLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topLista.LinkColor = System.Drawing.Color.Black;
            this.topLista.Location = new System.Drawing.Point(33, 53);
            this.topLista.Name = "topLista";
            this.topLista.Size = new System.Drawing.Size(67, 135);
            this.topLista.TabIndex = 16;
            this.topLista.TabStop = true;
            this.topLista.Text = "1 - NONE\r\n2 - NONE\r\n3 - NONE\r\n4 - NONE\r\n5 - NONE\r\n6 - NONE\r\n7 - NONE\r\n8 - NONE\r\n9" +
    " - NONE";
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.BackColor = System.Drawing.Color.OliveDrab;
            this.TOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TOP.Location = new System.Drawing.Point(45, 28);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(39, 16);
            this.TOP.TabIndex = 17;
            this.TOP.Text = "TOP";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pasek3
            // 
            this.pasek3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pasek3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pasek3.BackgroundImage")));
            this.pasek3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pasek3.InitialImage")));
            this.pasek3.Location = new System.Drawing.Point(159, -3);
            this.pasek3.Name = "pasek3";
            this.pasek3.Size = new System.Drawing.Size(11, 82);
            this.pasek3.TabIndex = 18;
            this.pasek3.TabStop = false;
            this.pasek3.Visible = false;
            // 
            // pasek4
            // 
            this.pasek4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pasek4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pasek4.BackgroundImage")));
            this.pasek4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pasek4.InitialImage")));
            this.pasek4.Location = new System.Drawing.Point(159, 147);
            this.pasek4.Name = "pasek4";
            this.pasek4.Size = new System.Drawing.Size(11, 82);
            this.pasek4.TabIndex = 19;
            this.pasek4.TabStop = false;
            this.pasek4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 262);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // przeszkoda3
            // 
            this.przeszkoda3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.przeszkoda3.Location = new System.Drawing.Point(369, 28);
            this.przeszkoda3.Name = "przeszkoda3";
            this.przeszkoda3.Size = new System.Drawing.Size(35, 31);
            this.przeszkoda3.TabIndex = 24;
            this.przeszkoda3.TabStop = false;
            // 
            // przeszkoda2
            // 
            this.przeszkoda2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.przeszkoda2.Location = new System.Drawing.Point(197, 28);
            this.przeszkoda2.Name = "przeszkoda2";
            this.przeszkoda2.Size = new System.Drawing.Size(35, 31);
            this.przeszkoda2.TabIndex = 23;
            this.przeszkoda2.TabStop = false;
            // 
            // przeszkoda1
            // 
            this.przeszkoda1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.przeszkoda1.Location = new System.Drawing.Point(284, 28);
            this.przeszkoda1.Name = "przeszkoda1";
            this.przeszkoda1.Size = new System.Drawing.Size(35, 31);
            this.przeszkoda1.TabIndex = 22;
            this.przeszkoda1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.przeszkoda3);
            this.Controls.Add(this.przeszkoda2);
            this.Controls.Add(this.przeszkoda1);
            this.Controls.Add(this.pasek1);
            this.Controls.Add(this.pasek4);
            this.Controls.Add(this.pasek2);
            this.Controls.Add(this.pasek3);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.topLista);
            this.Controls.Add(this.TOP);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pasek2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasek1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasek3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasek4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pasek2;
        private System.Windows.Forms.PictureBox pasek1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.LinkLabel topLista;
        private System.Windows.Forms.Label TOP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pasek3;
        private System.Windows.Forms.PictureBox pasek4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox przeszkoda3;
        private System.Windows.Forms.PictureBox przeszkoda2;
        private System.Windows.Forms.PictureBox przeszkoda1;
    }
}

