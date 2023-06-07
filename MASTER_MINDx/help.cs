using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASTER_MINDx
{
    public partial class help : Form
    {
        Form1 gra;
        public help(Form1 gra)
        {
            this.gra = gra;
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            if(gra.jezyk == "polish")
            {
                ins_tytul.Text = "ROZGRYWKA KROK PO KROKU";
                ins_pkt1.Text = "1. Kliknij przycisk LOSUJ KOMBINACJE - komputer losuje kombinację kolorów";
                ins_pkt2.Text = "2. Teraz wybierz wszystkie kolory w pierwszej ze zgadywanych kombinacji. Następnie kliknij przycisk SPRAWDŹ - komputer porówna Twoją propozycję z wylosowanym kodem";
                ins_pkt3.Text = "3. Komputer udzieli Ci odpowiedniej podpowiedzi. Jeśli kolor będzie właściwy i będzie na właściwym miejscu, pojawi się czarny kwadracik. Jeśli kolor będzie właściwy, ale na nieodpowiednim miejscu kwadracik będzie biały.";
                ins_pkt4.Text = "4. Powtarzaj krok 2 i 3 do momentu wygranej lub porażki.Następnie możesz zagrać ponownie wybierając przycisk RESETUJ";
                label1.Text = "Drogi Użytkowniku!";
                label2.Text = "Stworzona przeze mnie aplikacja stanowi odzwierciedlenie starej i nieco już zapomianej gry logicznej MasterMind. W dużym skrócie gra polega na odgadnięciu kombinacji kolorów wylosowanej przez drugiego gracza, a w tym wypadku komputer. Dobrej zabawy!";
            }
            else if(gra.jezyk == "english")
            {
                ins_tytul.Text = "GAMEPLAY STEP BY STEP";
                ins_pkt1.Text = "1. Click DRAW COMBINATION button - computer will draw combination of colours";
                ins_pkt2.Text = "2. Now choose all the colors in the first guessing segment. Then click the CHECK button - computer will compare your guess with prepared combination";
                ins_pkt3.Text = "3. Computer will give you appropriate hint. If the color is correct and it is placed corretly the black square will appear. If the color is correct but it is not placed correctly the square will be white";
                ins_pkt4.Text = "4. Repeat step 2 and 3 until winning or losing the game. Then you can play again by clicking RESET button";
                label1.Text = "Dear User!";
                label2.Text = "This app is a reflection of an old and somewhat forgotten logic game called MasterMind. In a nutshell the game is about guessing the combination of colours prepared by another player, in this case - computer. Have fun!";
            }
            else if(gra.jezyk == "german")
            {
                ins_tytul.Text = "Schritt fur Schritt Spielablauf";
                ins_pkt1.Text = "1. Druck den Knopf KOMBINATION ZIEHEN - der Computer randomisiert die Kombinationen";
                ins_pkt2.Text = "2. Wahlen Sie alle Farben in einer erratenden Kombination aus. Druck den Knopf UBERPRUFEN - der Computer vergleicht die Kombinationen";
                ins_pkt3.Text = "3. Der Computer gibt Ihnen einen Hinweis. Wenn die Farbe stimmt und an der richtigen Stelle ist - schwarzes Quadrat. Wenn die Farbe richtig ist, aber an der falschen Stelle - weisses Quadrat";
                ins_pkt4.Text = "4. Wiederholen Sie die Schritte 2 und 3 bis das Spiel vorbei ist. Sie konnen von vorne beginnen indem Sie auf ZURUCKSETZEN klicken";
                label1.Text = "Lieber Nutzer!";
                label2.Text = "Dieses Programm spielgelt ein altes und vergessenes Spiel wider MasterMind. Kurz gesagt, es geht darum, die vom anderen Spieler vorbereitete Kombination zu erraten. In diesem Fall spielen sie gegen den Computer. Habe Spass!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
