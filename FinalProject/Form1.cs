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
        int points = 0, szybkoscPrzeszkody = 5;
        int _X = 0;
        string nazwa, wynik;

        public Form1()
        {
                    
            InitializeComponent();

        }

        private void start_Click(object sender, EventArgs e)
        {
            
            start.Visible = false; //Znikanie przycisku
            timer1.Start(); 
            points = 0; //początkowa liczba punktów
            {
                pasek1.Visible = true;
                pasek2.Visible = true;
                pasek3.Visible = true;
                pasek4.Visible = true;
            }//paski po bokach
            {
                textBox1.ReadOnly = true;
                nazwa = textBox1.Text;
                textBox1.Visible = false;
            }//operacje na textBox

        }// Akcje po wciśnięciu start

        private void koniecGry()
        {
            Historia wy = new Historia();

            Historia.GameEndedEventHandler wyn = new Historia.GameEndedEventHandler(wy.tworzenieWyniku); 
            wynik = wyn(nazwa, points); // Przekazywanie finalnego wyniku do klasy Historia


            timer1.Stop();
            {
                pasek1.Visible = false;
                pasek2.Visible = false;
                pasek3.Visible = false;
                pasek4.Visible = false;
            }// paski znów znikają

            wy.Visible = true; // pojawia się okno Historii
            start.Visible = true; //Wraca przycisk startu
            textBox1.ReadOnly = false; // podaj nazwę znów może przyjmować znaki
            textBox1.Visible = true;    //pojawia się textbox


        } // Akcje po zakończeniu rundy

        public void przeszkodaRuch() 
        {
            if(przeszkoda1.Top >= 200 && przeszkoda1.Top <=240)
            {
                if (przeszkoda1.Width >= _X && przeszkoda1.Width -20<= _X+20)
                {
                    przeszkoda1.Top = -50;
                    koniecGry();
                }
            }// Wykrywacz kolizji
            
            if (przeszkoda1.Top >= 300)
            {
                przeszkoda1.Top = -50;
                szybkoscPrzeszkody += 1;
                points += 1;
                

            } // Jeśli przeszkoda zjedzie poza ramkę dostajesz punkt, prędkość jest zwiększana i wraca na początkową pozycję
            else
            {
                przeszkoda1.Top += szybkoscPrzeszkody;
            } // przeszkoda przyśpiesza
        } // Algorytm poruszania przeszkodą i kolizji z "postacią"   

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
        } // poruszanie paskami bocznymi

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); // wszystko poza tym co nadpisuję zostaje jak oryginalnie
            Graphics g = e.Graphics;
            Brush czerwonyKlocek = new SolidBrush(Color.Red); // wybieranie koloru
            g.TranslateTransform(_X, 0); // "przesówanie"
            g.FillRectangle(czerwonyKlocek, 300, 220, 20, 20); // tworzenie kwadratu
        } // nadpisanie OnPaint o wyświetlenie czerwonego kwadratu wielkości 20x20 i możliwość "przesówania"

        private void timer1_Tick(object sender, EventArgs e)
        {
            predkosc(5); // ściany boczne
            
            przeszkodaRuch(); // przeszkoda
            

        } // timer odmierzający szybkość poruszania się przeszkody oraz ścian bocznych

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)'a')
            {
                _X -= 5; // skręt w lewo
                
                this.Refresh();
            }
            if (e.KeyChar == (char)'d')
            {
                _X += 5;
                this.Refresh(); // skręt w prawo
            }
            if(e.KeyChar == (char)'p')
            {
                koniecGry(); // zakończenie gry
            }
        }  // poruszanie czerwonym kwadratem
    }


}
