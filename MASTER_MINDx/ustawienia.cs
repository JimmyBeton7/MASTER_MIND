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
    public partial class ustawienia : Form
    {
        Form1 gra;
        public ustawienia(Form1 gra)
        {
            this.gra = gra;
            InitializeComponent();
        }
        string language = "english";

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {          
            //Form1 gra = new Form1();

            if (language == "polish")
            {
                //english_language.Checked = false;
                //german_language.Checked = false;
                //ustawienia
                confirm_btn.Text = "POTWIERDŹ";
                close_btn.Text = "ZAMKNIJ";
                jezyk.Text = "Język: ";

                //gra                           
                gra.check_btn.Text = "SPRAWDŹ";
                gra.draw_btn.Text = "LOSUJ KOMBINACJĘ";
                gra.reset_btn.Text = "RESETUJ";
                gra.win.Text = "WYGRANA";
                gra.lose.Text = "PORAŻKA";
                gra.label1.Text = "WYBIERZ WSZYSTKIE KOLORY!";

                gra.jezyk = "polish";
                //Form1.form1Instance.check.Text = "SPRAWDŹ";
                //this.Hide();
            }

            if(english_language.Checked == true)
            {
                //polish_language.Checked = false;
                //german_language.Checked = false;
                //ustawienia
                confirm_btn.Text = "CONFIRM";
                close_btn.Text = "CLOSE";
                jezyk.Text = "Language: ";

                //gra                           
                gra.check_btn.Text = "CHECK";
                gra.draw_btn.Text = "DRAW COMBINATION";
                gra.reset_btn.Text = "RESET";
                gra.win.Text = "WIN";
                gra.lose.Text = "LOSE";
                gra.label1.Text = "Choose all the collors!";

                gra.jezyk = "english";
                //this.Hide();
            }

            if(german_language.Checked == true)
            {
                //polish_language.Checked = false;
                //english_language.Checked = false;
                //ustawienia
                confirm_btn.Text = "BESTATIGEN SIE";
                close_btn.Text = "NAH DRAN";
                jezyk.Text = "Sprache: ";

                //gra                           
                gra.check_btn.Text = "UBERPRUFEN";
                gra.draw_btn.Text = "KOMBINATION ZIEHEN";
                gra.reset_btn.Text = "ZURUCKSETZEN";
                gra.win.Text = "SIEG";
                gra.lose.Text = "VERLIEREN";
                gra.label1.Text = "Wahle alle Farben!";

                gra.jezyk = "german";
                //this.Hide();
            }

            if(hard_lvl.Checked == true && gra.difficulty == "easy")
            {
                const string message_eng = "Difficulty level has changed. Game will be restarted";
                const string message_pl = "Zmieniono poziom trudnosci. Gra zostanie zresetowana";
                const string message_ger = "Schwierigkeitsgrad geandert. Das Spiel wird zuruckgesetzt";
                const string caption_eng = "INFORMATION";
                const string caption_pl = "INFORMACJA";
                const string caption_ger = "INFORMATION";
                gra.difficulty = "hard";

                if(gra.jezyk == "english")
                {
                    MessageBox.Show(message_eng,caption_eng, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(gra.jezyk == "polish")
                {
                    MessageBox.Show(message_pl,caption_pl, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(gra.jezyk == "german")
                {
                    MessageBox.Show(message_ger,caption_ger, MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                gra.reset_btn_Click(sender,e);
            }

            if(easy_lvl.Checked == true && gra.difficulty == "hard")
            {
                const string message_eng = "Difficulty level has changed. Game will be restarted";
                const string message_pl = "Zmieniono poziom trudnosci. Gra zostanie zresetowana";
                const string message_ger = "Schwierigkeitsgrad geandert. Das Spiel wird zuruckgesetzt";
                const string caption_eng = "INFORMATION";
                const string caption_pl = "INFORMACJA";
                const string caption_ger = "INFORMATION";
                gra.difficulty = "easy";

                if (gra.jezyk == "english")
                {
                    MessageBox.Show(message_eng, caption_eng, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (gra.jezyk == "polish")
                {
                    MessageBox.Show(message_pl, caption_pl, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (gra.jezyk == "german")
                {
                    MessageBox.Show(message_ger, caption_ger, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gra.reset_btn_Click(sender, e);
            }
            this.Hide();
        }

        private void polish_language_CheckedChanged(object sender, EventArgs e)
        {
            polish_language.Checked = true;
            language = "polish";
        }

        private void ustawienia_Load(object sender, EventArgs e)
        {
            if(gra.jezyk == "polish")
            {
                confirm_btn.Text = "POTWIERDŹ";
                close_btn.Text = "ZAMKNIJ";
                jezyk.Text = "Język: ";
                //polish_language.Checked=true;
            }
            else if(gra.jezyk == "english")
            {
                confirm_btn.Text = "CONFIRM";
                close_btn.Text = "CLOSE";
                jezyk.Text = "Language: ";
                //english_language.Checked=true;
            }
            else if(gra.jezyk == "german")
            {
                confirm_btn.Text = "BESTATIGEN SIE";
                close_btn.Text = "NAH DRAN";
                jezyk.Text = "Sprache: ";
                //german_language.Checked=true;
            }
        }
    }
      
}
