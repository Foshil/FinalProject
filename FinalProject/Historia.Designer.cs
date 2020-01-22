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
            this.TOP = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.powrot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TOP.Location = new System.Drawing.Point(12, 9);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(39, 16);
            this.TOP.TabIndex = 19;
            this.TOP.Text = "TOP";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(96, 147);
            this.listBox1.TabIndex = 20;
            // 
            // powrot
            // 
            this.powrot.Location = new System.Drawing.Point(12, 188);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(96, 29);
            this.powrot.TabIndex = 21;
            this.powrot.Text = "Powrot do Menu";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.powrot_Click);
            // 
            // Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 229);
            this.Controls.Add(this.powrot);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TOP);
            this.Name = "Historia";
            this.Text = "Historia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TOP;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button powrot;
    }
}