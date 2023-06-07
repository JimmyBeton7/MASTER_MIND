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
    public partial class score : Form
    {
        public score()
        {
            InitializeComponent();
        }

        private void score_Load(object sender, EventArgs e)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string score_txt = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\MASTER_MINDx-master\scoreboard.txt");
            string file_path = Path.GetFullPath(score_txt);
            
            //string file_path = @"C:\Users\Mateusz\Desktop\VisualStudio-programy\MASTER_MINDx_0.04\MASTER_MINDx\scoreboard.txt";
            try
            {
                listBox1.Items.Clear();
                List<string> results = new List<string>();

                using (StreamReader plik = File.OpenText(file_path))
                {
                    //int licznik = 0;
                    //foreach (string linia in File.ReadAllLines(file_path))
                    //{
                    //    if (linia != String.Empty) ++licznik;
                    //}

                    //string[] lines = new string[licznik];
                    //foreach (string line in File.ReadLines(file_path))
                    //{
                    //    lines = File.ReadAllLines(file_path);
                    //    listBox1.Items.Add(line);
                    //}
                    string line;
                    while ((line = plik.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }

                    plik.Close();
                }
            }
            catch (IOException error)
            {
                MessageBox.Show("FILE READING ERROR");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string file_path = @"C:\Users\Mateusz\Desktop\VisualStudio-programy\MASTER_MINDx_0.04\MASTER_MINDx\scoreboard.txt";
            //try
            //{
            //    listBox1.Items.Clear();
            //    List<string> results = new List<string>();

            //    using (StreamReader plik = File.OpenText(file_path))
            //    {
            //        //int licznik = 0;
            //        //foreach (string linia in File.ReadAllLines(file_path))
            //        //{
            //        //    if (linia != String.Empty) ++licznik;
            //        //}

            //        //string[] lines = new string[licznik];
            //        //foreach (string line in File.ReadLines(file_path))
            //        //{
            //        //    lines = File.ReadAllLines(file_path);
            //        //    listBox1.Items.Add(line);
            //        //}
            //        string line;
            //        while ((line = plik.ReadLine()) != null)
            //        {
            //            listBox1.Items.Add(line);
            //        }

            //        plik.Close();
            //    }
            //}
            //catch (IOException error)
            //{
            //    MessageBox.Show("FILE READING ERROR");
            //}
        }
    }
}
