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
    public partial class Historia : Form
    {

        public delegate string GameEndedEventHandler(string nazwa1, int punkty1); // stworzenie delegata przyjmującego dane do wyniku
        
        public Historia()
        {
            InitializeComponent();
           

        }

        public string tworzenieWyniku(string nazwa1, int punkty1)
        {
            dodajWynik(nazwa1 + ": " + punkty1 + "\n");
            return nazwa1 + ": " + punkty1 + "\n";
        } // dodanie wyniku z Form1.koniecGry do metody dodajWynik za pośrednictwem delegata, trochę brak pomysłu...

        private void koniecGry(string wynik)
        {
            
             topLista.Text += wynik;
            
        } //Dodaję otrzymany wynik i nazwę do listy w historii

        public void dodajWynik(string wynik) 
        {
            koniecGry(wynik);
        } // nadaję wynik do prywatnej metody koniecGry

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Dispose();

        } // zamknięcie okna po wciśnięciu dużego przycisku
    }
}
