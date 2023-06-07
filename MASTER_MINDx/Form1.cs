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
    public partial class Form1 : Form
    {
        public static Form1 form1Instance;
        public Button check;

        public string jezyk = "english";
        public string difficulty = "easy";
        public int licznik_sek = 0;
        public int minutes = 0;
        public Form1()
        {
            InitializeComponent();
            form1Instance = this;
            check = check_btn;
        }
        bool game_won = false;
        bool all_colors_chosed = true;

        int nr_tury = 1;

        int blackPeg = 0;   
        int whitePeg = 0;

        //colors
        const int blue = 1;
        const int green = 2;
        const int red = 3;
        const int yellow = 4;
        const int brown = 5;
        const int orange = 6;
        const int fuchsia = 7;

        
        int[] computer_combination = new int[4];
        int[] player_combination = new int[4];

        int l1 = 0;
        int l2 = 0;
        int l3 = 0;
        int l4 = 0;
        int l5 = 0;
        int l6 = 0;
        int l7 = 0;
        int l8 = 0;
        int l9 = 0;
        int l10 = 0;
        int l11 = 0;
        int l12 = 0;
        int l13 = 0;
        int l14 = 0;
        int l15 = 0;
        int l16 = 0;
        int l17 = 0;
        int l18 = 0;
        int l19 = 0;
        int l20 = 0;
        int l21 = 0;
        int l22 = 0;
        int l28 = 0;
        int l27 = 0;
//----------------------------------------------------------------------------------
        public bool AllColorsChosed(Button btn_1,Button btn_2,Button btn_3, Button btn_4)
        {
            if (btn_1.BackColor != Color.Silver && btn_2.BackColor != Color.Silver &&
                btn_3.BackColor != Color.Silver && btn_4.BackColor != Color.Silver)
            {
                return true;
            }
            else return false;
        }
//-------------------------------------------------------------------------------------

        public void Buttons(int l, Button b)
        {
            if(difficulty == "easy")
            {
                switch(l)
                {
                    case 1: { b.BackColor = Color.Blue;break; }
                    case 2: { b.BackColor = Color.Green;break; }
                    case 3: { b.BackColor = Color.Red;break; }
                    case 4: { b.BackColor = Color.Yellow;break; }
                    case 5: { b.BackColor = Color.Brown; break; }
                    case 6: { b.BackColor = Color.Orange;break; }
                }
            }
            else if(difficulty == "hard")
            {
                switch (l)
                {
                    case 1: { b.BackColor = Color.Blue; break; }
                    case 2: { b.BackColor = Color.Green; break; }
                    case 3: { b.BackColor = Color.Red; break; }
                    case 4: { b.BackColor = Color.Yellow; break; }
                    case 5: { b.BackColor = Color.Brown; break; }
                    case 6: { b.BackColor = Color.Orange; break; }
                    case 7: { b.BackColor = Color.Fuchsia; break; }
                }             
            }
        }

//-------------------------------------------------------------------------------------
        public void Check_Combination(Button b_a, Button b_b, Button b_c, Button b_d,
            Button btn_t_a, Button btn_t_b,
            Button btn_t_c, Button btn_t_d) 
        {
            
                label1.Visible = false;
                //get player combination
                //button_a
                if (b_a.BackColor == Color.Blue) player_combination[0] = 1;
                if (b_a.BackColor == Color.Green) player_combination[0] = 2;
                if (b_a.BackColor == Color.Red) player_combination[0] = 3;
                if (b_a.BackColor == Color.Yellow) player_combination[0] = 4;
                if (b_a.BackColor == Color.Brown) player_combination[0] = 5;
                if (b_a.BackColor == Color.Orange) player_combination[0] = 6;
                if (b_a.BackColor == Color.Fuchsia) player_combination[0] = 7;
                //button_b
                if (b_b.BackColor == Color.Blue) player_combination[1] = 1;
                if (b_b.BackColor == Color.Green) player_combination[1] = 2;
                if (b_b.BackColor == Color.Red) player_combination[1] = 3;
                if (b_b.BackColor == Color.Yellow) player_combination[1] = 4;
                if (b_b.BackColor == Color.Brown) player_combination[1] = 5;
                if (b_b.BackColor == Color.Orange) player_combination[1] = 6;
                if (b_b.BackColor == Color.Fuchsia) player_combination[1] = 7;

                //button_c
                if (b_c.BackColor == Color.Blue) player_combination[2] = 1;
                if (b_c.BackColor == Color.Green) player_combination[2] = 2;
                if (b_c.BackColor == Color.Red) player_combination[2] = 3;
                if (b_c.BackColor == Color.Yellow) player_combination[2] = 4;
                if (b_c.BackColor == Color.Brown) player_combination[2] = 5;
                if (b_c.BackColor == Color.Orange) player_combination[2] = 6;
                if (b_c.BackColor == Color.Fuchsia) player_combination[2] = 7;

                //button_d
                if (b_d.BackColor == Color.Blue) player_combination[3] = 1;
                if (b_d.BackColor == Color.Green) player_combination[3] = 2;
                if (b_d.BackColor == Color.Red) player_combination[3] = 3;
                if (b_d.BackColor == Color.Yellow) player_combination[3] = 4;
                if (b_d.BackColor == Color.Brown) player_combination[3] = 5;
                if (b_d.BackColor == Color.Orange) player_combination[3] = 6;
                if (b_d.BackColor == Color.Fuchsia) player_combination[3] = 7;


                //comparing arrays
                int[] computer_combination_X = new int[4];
                int[] player_combination_X = new int[4];

                for (int i = 0; i < 4; i++)
                {
                    computer_combination_X[i] = computer_combination[i];
                    player_combination_X[i] = player_combination[i];
                }

                for (int i = 0; i < 4; i++)
                {
                    if (player_combination_X[i] == computer_combination_X[i])
                    {
                        blackPeg++;
                        computer_combination_X[i] = -1;
                        player_combination_X[i] = -2;
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (player_combination_X[i] == computer_combination_X[j])
                        {
                            whitePeg++;
                            computer_combination_X[j] = -1;
                            player_combination_X[i] = -2;
                            break;
                        }
                    }
                }

                //mark the hints
                Button[] hints = new Button[] { btn_t_a, btn_t_b, btn_t_c, btn_t_d };

                if (blackPeg == 4)
                {
                    win.Visible = true; //player win
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                    groupBox5.Enabled = false;
                    groupBox6.Enabled = false;
                    check_btn.Enabled = false;
                    game_won = true;

                    btn_a.Visible = true;
                    btn_b.Visible = true;
                    btn_c.Visible = true;
                    btn_d.Visible = true;
                    timer_time.Enabled = false;

                    addplayer nowygracz = new addplayer(this);
                    nowygracz.ShowDialog();
                }

                //mark the hints
                for (int i = 0; i < blackPeg; i++)
                {
                    hints[i].BackColor = Color.Black;
                }

                for (int i = 0; i < whitePeg; i++)
                {
                    if (blackPeg > 0)
                    {
                        hints[i + blackPeg].BackColor = Color.White;
                    }
                    else if (blackPeg == 0)
                    {
                        hints[i].BackColor = Color.White;
                    }
                }
                    
        }
//-------------------------------------------------------------------------------------
        private void draw_btn_Click(object sender, EventArgs e)
        {
            draw_btn.Enabled = false;
            check_btn.Enabled = true;
            timer_time.Enabled = true;

            Random rand = new Random();
            int a, b, c, d;

            if(difficulty == "easy")
            {
                a = rand.Next(1, 7);
                b = rand.Next(1, 7);
                c = rand.Next(1, 7);
                d = rand.Next(1, 7);

                computer_combination[0] = a;
                computer_combination[1] = b;
                computer_combination[2] = c;
                computer_combination[3] = d;
            }
            else
            {
                a = rand.Next(1, 8);
                b = rand.Next(1, 8);
                c = rand.Next(1, 8);
                d = rand.Next(1, 8);

                computer_combination[0] = a;
                computer_combination[1] = b;
                computer_combination[2] = c;
                computer_combination[3] = d;
            }
            
            switch (a)
            {
                case 1: { btn_a.BackColor = Color.Blue; break; }
                case 2: { btn_a.BackColor = Color.Green; break; }
                case 3: { btn_a.BackColor = Color.Red; break; }
                case 4: { btn_a.BackColor = Color.Yellow; break; }
                case 5: { btn_a.BackColor = Color.Brown; break; }
                case 6: { btn_a.BackColor = Color.Orange; break; }
                case 7: { btn_a.BackColor = Color.Fuchsia;break; }
            }

            switch (b)
            {
                case 1: { btn_b.BackColor = Color.Blue; break; }
                case 2: { btn_b.BackColor = Color.Green; break; }
                case 3: { btn_b.BackColor = Color.Red; break; }
                case 4: { btn_b.BackColor = Color.Yellow; break; }
                case 5: { btn_b.BackColor = Color.Brown; break; }
                case 6: { btn_b.BackColor = Color.Orange; break; }
                case 7: { btn_b.BackColor = Color.Fuchsia;break; }
            }

            switch (c)
            {
                case 1: { btn_c.BackColor = Color.Blue; break; }
                case 2: { btn_c.BackColor = Color.Green; break; }
                case 3: { btn_c.BackColor = Color.Red; break; }
                case 4: { btn_c.BackColor = Color.Yellow; break; }
                case 5: { btn_c.BackColor = Color.Brown; break; }
                case 6: { btn_c.BackColor = Color.Orange; break; }
                case 7: { btn_c.BackColor = Color.Fuchsia; break; }
            }

            switch (d)
            {
                case 1: { btn_d.BackColor = Color.Blue; break; }
                case 2: { btn_d.BackColor = Color.Green; break; }
                case 3: { btn_d.BackColor = Color.Red; break; }
                case 4: { btn_d.BackColor = Color.Yellow; break; }
                case 5: { btn_d.BackColor = Color.Brown; break; }
                case 6: { btn_d.BackColor = Color.Orange; break; }
                case 7: { btn_d.BackColor = Color.Fuchsia; break; }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            l1++;
            Buttons(l1, button1);
            if (difficulty == "easy" && l1 == 6) l1 = 0;
            else if (difficulty == "hard" && l1 == 7) l1 = 0; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l3++;
            Buttons(l3, button3);
            if (difficulty == "easy" && l3 == 6) l3 = 0;
            else if (difficulty == "hard" && l3 == 7) l3 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            l4++;
            Buttons(l4, button4);
            if (difficulty == "easy" && l4 == 6) l4 = 0;
            else if (difficulty == "hard" && l4 == 7) l4 = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l2++;
            Buttons(l2, button2);
            if (difficulty == "easy" && l2 == 6) l2 = 0;
            else if (difficulty == "hard" && l2 == 7) l2 = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            l15++;
            Buttons(l15, button15);
            if (difficulty == "easy" && l15 == 6) l15 = 0;
            else if (difficulty == "hard" && l15 == 7) l15 = 0;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            l28++;
            Buttons(l28, button28);
            if (difficulty == "easy" && l28 == 6) l28 = 0;
            else if (difficulty == "hard" && l28 == 7) l28 = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            l19++;
            Buttons(l19, button19);
            if (difficulty == "easy" && l19 == 6) l19 = 0;
            else if (difficulty == "hard" && l19 == 7) l19 = 0;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            l27++;
            Buttons(l27, button27);
            if (difficulty == "easy" && l27 == 6) l27 = 0;
            else if (difficulty == "hard" && l27 == 7) l27 = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            l18++;
            Buttons(l18, button18);
            if (difficulty == "easy" && l18 == 6) l18 = 0;
            else if (difficulty == "hard" && l18 == 7) l18 = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            l8++;
            Buttons(l8, button8);
            if (difficulty == "easy" && l8 == 6) l8 = 0;
            else if (difficulty == "hard" && l8 == 7) l8 = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            l6++;
            Buttons(l6, button6);
            if (difficulty == "easy" && l6 == 6) l6 = 0;
            else if (difficulty == "hard" && l6 == 7) l6 = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            l7++;
            Buttons(l7, button7);
            if (difficulty == "easy" && l7 == 6) l7 = 0;
            else if (difficulty == "hard" && l7 == 7) l7 = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            l5++;
            Buttons(l5, button5);
            if (difficulty == "easy" && l5 == 6) l5 = 0;
            else if (difficulty == "hard" && l5 == 7) l5 = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            l12++;
            Buttons(l12, button12);
            if (difficulty == "easy" && l12 == 6) l12 = 0;
            else if (difficulty == "hard" && l12 == 7) l12 = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            l10++;
            Buttons(l10, button10);
            if (difficulty == "easy" && l10 == 6) l10 = 0;
            else if (difficulty == "hard" && l10 == 7) l10 = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            l11++;
            Buttons(l11, button11);
            if (difficulty == "easy" && l11 == 6) l11 = 0;
            else if (difficulty == "hard" && l11 == 7) l11 = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            l9++;
            Buttons(l9, button9);
            if (difficulty == "easy" && l9 == 6) l9 = 0;
            else if (difficulty == "hard" && l9 == 7) l9 = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            l16++;
            Buttons(l16, button16);
            if (difficulty == "easy" && l16 == 6) l16 = 0;
            else if (difficulty == "hard" && l16 == 7) l16 = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            l14++;
            Buttons(l14, button14);
            if (difficulty == "easy" && l14 == 6) l14 = 0;
            else if (difficulty == "hard" && l14 == 7) l14 = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            l13++;
            Buttons(l13, button13);
            if (difficulty == "easy" && l13 == 6) l13 = 0;
            else if (difficulty == "hard" && l13 == 7) l13 = 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            l22++;
            Buttons(l22, button22);
            if (difficulty == "easy" && l22 == 6) l22 = 0;
            else if (difficulty == "hard" && l22 == 7) l22 = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            l20++;
            Buttons(l20, button20);
            if (difficulty == "easy" && l20 == 6) l20 = 0;
            else if (difficulty == "hard" && l20 == 7) l20 = 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            l21++;
            Buttons(l21, button21);
            if (difficulty == "easy" && l21 == 6) l21 = 0;
            else if (difficulty == "hard" && l21 == 7) l21 = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            l17++;
            Buttons(l17, button17);
            if (difficulty == "easy" && l17 == 6) l17 = 0;
            else if (difficulty == "hard" && l17 == 7) l17 = 0;
        }

        public void reset_btn_Click(object sender, EventArgs e)
        { 
            button1.BackColor = Color.Silver;
            button2.BackColor = Color.Silver;
            button3.BackColor = Color.Silver;
            button4.BackColor = Color.Silver;
            button5.BackColor = Color.Silver;
            button6.BackColor = Color.Silver;
            button7.BackColor = Color.Silver;
            button8.BackColor = Color.Silver;
            button9.BackColor = Color.Silver;
            button10.BackColor = Color.Silver;
            button11.BackColor = Color.Silver;
            button12.BackColor = Color.Silver;
            button13.BackColor = Color.Silver;
            button14.BackColor = Color.Silver;
            button15.BackColor = Color.Silver;
            button16.BackColor = Color.Silver;
            button17.BackColor = Color.Silver;
            button18.BackColor = Color.Silver;
            button19.BackColor = Color.Silver;
            button20.BackColor = Color.Silver;
            button21.BackColor = Color.Silver;
            button22.BackColor = Color.Silver;
            button27.BackColor = Color.Silver;
            button28.BackColor = Color.Silver;

            l1 = 0; l2 = 0; l3 = 0; l4 = 0; l5 = 0; l6 = 0; l7 = 0; l8 = 0;
            l9 = 0; l10 = 0; l11 = 0; l12 = 0; l13 = 0; l14 = 0; l15 = 0;
            l16 = 0; l17 = 0; l18 = 0; l19 = 0; l20 = 0; l21 = 0; l22 = 0;
            l27 = 0; l28 = 0;

            btn_a.BackColor = Color.Silver;
            btn_b.BackColor = Color.Silver;
            btn_c.BackColor = Color.Silver;
            btn_d.BackColor = Color.Silver;
            //btn_a.Visible = false;
            //btn_b.Visible = false;
            //btn_c.Visible = false;
            //btn_d.Visible = false;

            btn_t1_a.BackColor = Color.Silver;
            btn_t1_b.BackColor = Color.Silver;
            btn_t1_c.BackColor = Color.Silver;
            btn_t1_d.BackColor = Color.Silver;
            btn_t2_a.BackColor = Color.Silver;
            btn_t2_b.BackColor = Color.Silver;
            btn_t2_c.BackColor = Color.Silver;
            btn_t2_d.BackColor = Color.Silver;
            btn_t3_a.BackColor = Color.Silver;
            btn_t3_b.BackColor = Color.Silver;
            btn_t3_c.BackColor = Color.Silver;
            btn_t3_d.BackColor = Color.Silver;
            btn_t4_a.BackColor = Color.Silver;
            btn_t4_b.BackColor = Color.Silver;
            btn_t4_c.BackColor = Color.Silver;
            btn_t4_d.BackColor = Color.Silver;
            btn_t5_a.BackColor = Color.Silver;
            btn_t5_b.BackColor = Color.Silver;
            btn_t5_c.BackColor = Color.Silver;
            btn_t5_d.BackColor = Color.Silver;
            btn_t6_a.BackColor = Color.Silver;
            btn_t6_b.BackColor = Color.Silver;
            btn_t6_c.BackColor = Color.Silver;
            btn_t6_d.BackColor = Color.Silver;

            draw_btn.Enabled = true;
            check_btn.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            nr_tury = 1;

            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;
            win.Visible = false;
            lose.Visible = false;
            blackPeg = 0;
            whitePeg = 0;

            licznik_sek = 0;
            minutes = 0;
            timer_time.Enabled = false;
            time_lbl.Text = "00:00";
            game_won = false;
        }
//-------------------------------------------------------------------------------
        private void check_btn_Click(object sender, EventArgs e)
        {
            switch(nr_tury)
            {
                case 1:
                    {
                        if(AllColorsChosed(button1,button4,button3,button2) == true)
                        {
                            Check_Combination(button1, button4, button3, button2, btn_t1_a, btn_t1_b, btn_t1_c, btn_t1_d);
                            nr_tury++;
                            label1.Visible = false;
                            if (game_won != true)
                            {
                                groupBox1.Enabled = false;
                                groupBox2.Enabled = true;
                                blackPeg = 0;
                                whitePeg = 0;
                            }
                        }
                        else
                        {
                            label1.Visible = true;
                        }
                                            
                        break;
                    }
                case 2:
                    {
                        if(AllColorsChosed(button18,button19,button27,button28)==true)
                        {
                            Check_Combination(button18, button19, button27, button28, btn_t2_a, btn_t2_b, btn_t2_c, btn_t2_d);
                            nr_tury++;
                            label1.Visible=false;
                            if (game_won != true)
                            {
                                groupBox2.Enabled = false;
                                groupBox3.Enabled = true;
                                blackPeg = 0;
                                whitePeg = 0;
                            }                           
                        }
                        else
                        {
                            label1.Visible=true;
                        }
                        break;
                    }
                case 3:
                    {
                        if(AllColorsChosed(button5,button6,button7,button8)==true)
                        {
                            Check_Combination(button5, button6, button7, button8, btn_t3_a, btn_t3_b, btn_t3_c, btn_t3_d);
                            nr_tury++;
                            label1.Visible = false;
                            if (game_won != true)
                            {
                                groupBox3.Enabled = false;
                                groupBox4.Enabled = true;
                                blackPeg = 0;
                                whitePeg = 0;
                            }
                        }
                        else
                        {
                            label1.Visible = true;
                        }
                        
                        break;
                    }
                case 4:
                    {
                        if(AllColorsChosed(button9,button10,button11,button12)==true)
                        {
                            Check_Combination(button9, button10, button11, button12, btn_t4_a, btn_t4_b, btn_t4_c, btn_t4_d);
                            nr_tury++; //all_colors_chosed == true
                            label1.Visible = false; 
                            if (game_won != true)
                            {
                                groupBox4.Enabled = false;
                                groupBox5.Enabled = true;
                                blackPeg = 0;
                                whitePeg = 0;
                            }
                        }
                        else
                        {
                            label1.Visible=true;
                        }
                        
                        break;
                    }
                case 5:
                    {
                        if(AllColorsChosed(button13,button14,button15,button16)==true)
                        {
                            Check_Combination(button13, button14, button15, button16, btn_t5_a, btn_t5_b, btn_t5_c, btn_t5_d);
                            nr_tury++;
                            label1.Visible = false;
                            if (game_won != true)
                            {
                                groupBox5.Enabled = false;
                                groupBox6.Enabled = true;
                                blackPeg = 0;
                                whitePeg = 0;
                            }
                        }
                        else
                        {
                            label1.Visible=true;
                        }
                        
                        break;
                    }
                case 6:
                    {
                        if(AllColorsChosed(button17,button20,button21,button22)==true)
                        {
                            Check_Combination(button17, button20, button21, button22, btn_t6_a, btn_t6_b, btn_t6_c, btn_t6_d);
                            nr_tury++;
                            label1.Visible = false;
                            if (game_won != true)
                            {
                                groupBox6.Enabled = false;
                                blackPeg = 0;
                                whitePeg = 0;
                                lose.Visible = true;
                                check_btn.Enabled = false;

                                btn_a.Visible = true;
                                btn_b.Visible = true;
                                btn_c.Visible = true;
                                btn_d.Visible = true;

                                timer_time.Enabled = false;                                                                                         
                            }
                        }
                        else
                        {
                            label1.Visible = true;
                        }
                        
                        break;
                    }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            ustawienia settings = new ustawienia(this);
            settings.Owner = this;
            settings.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            help pomoc1 = new help(this);
            pomoc1.Owner = this;
            pomoc1.ShowDialog();
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            licznik_sek++;
            
            //int minuty = 0;

            if (licznik_sek == 60)
            {
                licznik_sek = 1;
                minutes++;
            }
            
            if(minutes <= 0 && (licznik_sek >= 0 && licznik_sek < 10))
            {
                time_lbl.Text = "00:0" + licznik_sek;
            }
            else if(minutes <= 0 && (licznik_sek>=10))
            {
                time_lbl.Text = "00:" + licznik_sek;
            }
            else if((minutes >= 0 && minutes <10) && (licznik_sek >= 0 && licznik_sek <10))
            {
                time_lbl.Text = "0" + minutes + ":" + "0" + licznik_sek;
            }
            else if(minutes >= 10 && licznik_sek >=10)
            {
                time_lbl.Text = minutes +":"+ licznik_sek;
            }
        }

        private void score_btn_Click(object sender, EventArgs e)
        {
            score wyniki = new score();
            wyniki.Owner = this;
            wyniki.Show();
        }
    }
}
