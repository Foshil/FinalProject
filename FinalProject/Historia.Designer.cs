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
            this.SuspendLayout();
            // 
            // topLista
            // 
            this.topLista.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.topLista.AutoSize = true;
            this.topLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.topLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topLista.LinkColor = System.Drawing.Color.Black;
            this.topLista.Location = new System.Drawing.Point(83, 96);
            this.topLista.Name = "topLista";
            this.topLista.Size = new System.Drawing.Size(67, 135);
            this.topLista.TabIndex = 18;
            this.topLista.TabStop = true;
            this.topLista.Text = "1 - NONE\r\n2 - NONE\r\n3 - NONE\r\n4 - NONE\r\n5 - NONE\r\n6 - NONE\r\n7 - NONE\r\n8 - NONE\r\n9" +
    " - NONE";
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TOP.Location = new System.Drawing.Point(98, 65);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(39, 16);
            this.TOP.TabIndex = 19;
            this.TOP.Text = "TOP";
            // 
            // Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 312);
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
    }
}