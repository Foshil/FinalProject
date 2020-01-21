using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    
    
    public partial class Form1 : Form
    {
        int points = 0;
        int _X = 200;
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            //rysujPostac();
        }

        private void start_Click(object sender, EventArgs e)
        {
            //Postac postac = new Postac();
            start.Dispose();
            topLista.Dispose();
            rysujPostac();
            TOP.Dispose();
            timer1.Start();
            pasek1.Visible = true;
            pasek2.Visible = true;
            pasek3.Visible = true;
            pasek4.Visible = true;
            

        }

        private void rysujPostac()
        {
            
            Brush myBrush = new SolidBrush(Color.Red);
            //player.Visible = true;
           // player.BackColor{ Get;Set }
            
        }

        void predkosc(int speed)
        {
            if (pasek1.Top >= 300)
            {
                pasek1.Top = -50;
            }
            else
            {
                pasek1.Top += speed;
            }
            if (pasek2.Top >= 300)
            {
                pasek2.Top = -50;
            }
            else
            {
                pasek2.Top += speed;
            }
            if (pasek3.Top >= 300)
            {
                pasek3.Top = -50;
            }else
            {
                pasek3.Top += speed;
            }
            if (pasek4.Top >= 300)
            {
                pasek4.Top = -50;
            }else
            {
                pasek4.Top += speed;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Stencil",12,FontStyle.Regular);
            TextRenderer.DrawText(dc, "Points=" + this.points.ToString(), _font,
                new Rectangle(0, 0, 120, 20), SystemColors.ControlText, flags);
            
            base.OnPaint(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            predkosc(5);
            points += 1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)97:
                    _X += 1;
                    break;

            }
                this.Refresh();
        }
    }


}
