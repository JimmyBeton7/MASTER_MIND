using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASTER_MINDx
{
    public partial class addplayer : Form
    {
        Form1 gra;
        public string imie;
        public string level;
        public addplayer(Form1 gra)
        {
            this.gra = gra;
            InitializeComponent();
        }

        private void dontsave_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addplayer_btn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                imie = textBox1.Text;
                level = gra.difficulty;
                DateTime localDate = DateTime.Now;
                string date_str = localDate.ToString("dd/MM/yyyy;HH:mm:ss");

                string date = date_str;
                string file_path = @"C:\Users\Mateusz\Desktop\VisualStudio-programy\MASTER_MINDx_0.04\MASTER_MINDx\scoreboard.txt";
                StreamWriter plik = new StreamWriter(file_path, true);

                plik.WriteLine(date + "," + imie + ", "+gra.minutes + ":" + gra.licznik_sek + ";" + level);
                plik.Close();
                label2.Visible = false;

                this.Hide();
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void addplayer_Load(object sender, EventArgs e)
        {
            if(gra.jezyk == "english")
            {
                label1.Text = "Choose your name";
                addplayer_btn.Text = "Add player name";
                dontsave_btn.Text = "Don't save";
                label2.Text = "If you want to save your score, you must choose the name";
            }
            else if(gra.jezyk == "polish")
            {
                label1.Text = "Wpisz swoje imię";
                addplayer_btn.Text = "Dodaj imię gracza";
                dontsave_btn.Text = "Nie zapisuj";
                label2.Text = "Jesli chcesz zapisac swój wynik, musisz wybrać imię";
            }
            else if(gra.jezyk == "german")
            {
                label1.Text = "Wahle deine Namen";
                addplayer_btn.Text = "Spielernamen hinzufugen";
                dontsave_btn.Text = "Nicht speichern";
                label2.Text = "Wenn Sie Ihre Partitur speichern mochten, mussen Sie einen Namen wahlen";
            }
        }
    }
}
