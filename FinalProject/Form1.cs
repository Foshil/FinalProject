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
        Historia h = new Historia();
        int nrPrzeszkody = 0;
        Boolean prze = false;
        int points = 10;
        int _X = 300;
        int _Y = 220;
        string name = "Filip";

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            //rysujPostac();
            przeszkoda1.Visible = false;
            przeszkoda2.Visible = false;
            przeszkoda3.Visible = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(rysujPostac);
            start.Visible = false;
            topLista.Visible = false;
            
            TOP.Visible = false;
            timer1.Start();
            pasek1.Visible = true;
            pasek2.Visible = true;
            pasek3.Visible = true;
            pasek4.Visible = true;
            prze = true;
            przeszkoda1.Visible = true;
        }

        private void stop_Game()
        {
            start.Visible = true;
            topLista.Visible = true;
            TOP.Visible = true;
            pasek1.Visible = false;
            pasek2.Visible = false;
            pasek3.Visible = false;
            pasek4.Visible = false;
            timer1.Stop();
            przeszkoda1.Visible = false;
            przeszkoda2.Visible = false;
            przeszkoda3.Visible = false;
            h.dodajWynik(points, name);
            h.Visible = true;
            //this.Dispose();

        }

        private void rysujPostac(object sender,PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush myBrush = new SolidBrush(Color.Red);

            g.FillRectangle(myBrush, _X, _Y, 20, 20);
            
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

        void przeszkoda(int speed, int nrPrzeszkody)
        {
            if (nrPrzeszkody == 0 && prze == true && przeszkoda1.Top < 300)
            {
                przeszkoda1.Top += speed;
            }
            else if (przeszkoda1.Top >= 300 && nrPrzeszkody == 0)
            {
                przeszkoda1.Top = -50;
                przeszkoda1.Visible = false;
                nrPrzeszkody++;
                stop_Game(); // na chwilę

            }
            else if (crashEvent(przeszkoda1.Top, przeszkoda1.Width)) 
            {
                stop_Game();
            }  
        }

        bool crashEvent(int pozycjaY, int pozycjaX)
        {
            if (pozycjaX + 20 >= _X && pozycjaY + 20 >= _Y && pozycjaX < _X + 20 && pozycjaY < _Y + 20) ;
            {
                stop_Game();
                return false;
            }
        }

        void przeszkodaDwa(int speed, int nrPrzeszkody)
        {
            if (nrPrzeszkody == 0 && prze == true && przeszkoda2.Top < 300)
            {
                przeszkoda2.Top += speed;
            }
            else if (przeszkoda2.Top >= 300)
            {
                przeszkoda2.Top = -50;
                przeszkoda2.Visible = false;
        
            }else if (prze == false) 
            {
                stop_Game();
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
            przeszkoda(5, nrPrzeszkody);
            
            points += 1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    _X += 5;
                    this.Refresh();
                    break;
                case 'd':
                    _X -= 5;
                    this.Refresh();
                    break;

            }
                
        }
    }


}
