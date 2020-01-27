namespace FinalProject
{
    partial class Historia
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
            this.topLista = new System.Windows.Forms.LinkLabel();
            this.TOP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLista
            // 
            this.topLista.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.topLista.AutoSize = true;
            this.topLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.topLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topLista.LinkColor = System.Drawing.Color.Black;
            this.topLista.Location = new System.Drawing.Point(89, 25);
            this.topLista.Name = "topLista";
            this.topLista.Size = new System.Drawing.Size(0, 15);
            this.topLista.TabIndex = 18;
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TOP.Location = new System.Drawing.Point(102, 9);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(62, 16);
            this.TOP.TabIndex = 19;
            this.TOP.Text = "Historia";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(13, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 129);
            this.button1.TabIndex = 20;
            this.button1.Text = "Menu główne";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topLista);
            this.Controls.Add(this.TOP);
            this.Name = "Historia";
            this.Text = "Historia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel topLista;
        private System.Windows.Forms.Label TOP;
        private System.Windows.Forms.Button button1;
    }
}