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
       // Form1 okno = new Form1();
        int[] TopGameHistory = new int[10];
        string[] TopGameHistoryNames = new string[10];
        public delegate void podajMiejsce(int i);
        public Historia()
        {
            this.AutoSize = false;
            InitializeComponent();
        }
        
        public void dodajWynik(int wynik, string imie)
        {
            bool dodanyWynik = false;
            for (int i = 0; i < TopGameHistory.Length; i++)
            {
                if (TopGameHistory[i] == 0 && dodanyWynik == false)
                {
                    TopGameHistory[i] = wynik;
                    TopGameHistoryNames[i] = imie;
                    dodanyWynik = true;
                   // listBox1.Items.Add(TopGameHistory[i] + TopGameHistoryNames[i]);



                }
                else if (dodanyWynik == false && TopGameHistory[i] < wynik)
                {
                    TopGameHistory[i] = wynik;
                    TopGameHistoryNames[i] = imie;
                    dodanyWynik = true;
                    //listBox1.Items.Remove(i);
                    //listBox1.Items.Add(TopGameHistory[i] + TopGameHistoryNames[i]);
                }

            }
        }
        // Dotychczasowe dodawanie wyników
        public void dodajWynik(int wynik, string imie, podajMiejsce obj)
        {
            bool dodanyWynik = false;
            for (int i = 0; i < TopGameHistory.Length; i++)
            {
                if (TopGameHistory[i] == 0 && dodanyWynik == false)
                {
                    TopGameHistory[i] = wynik;
                    TopGameHistoryNames[i] = imie;
                    dodanyWynik = true;
                   // listBox1.Items.Add(TopGameHistory[i] + TopGameHistoryNames[i]);



                }
                else if (dodanyWynik == false && TopGameHistory[i] < wynik)
                {
                    TopGameHistory[i] = wynik;
                    TopGameHistoryNames[i] = imie;
                    dodanyWynik = true;
                    //listBox1.Items.Remove(i);
                    //listBox1.Items.Add(TopGameHistory[i] + TopGameHistoryNames[i]);
                }

            }
        }

        public int[] zwrocWyniki()
        {
            return TopGameHistory;
        }

        public string[] zwrocNazwy()
        {
            return TopGameHistoryNames;
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Visible = false;
          //  okno.Visible = true;
        }
    }
    
}
