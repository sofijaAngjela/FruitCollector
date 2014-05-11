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
using FruitCollector.Properties;
using System.Media;
namespace FruitCollector
{
    public partial class Form1 : Form
    {

        public static String ime = "Fruit Collector";
        public static String player;
        public String igg;
        public int br { get; set; }
        public int nbIgra { get; set; }
        public String igrach;
        Bitmap bmp;
        bool play;
        SoundPlayer song;
        public Form1()
        {
            InitializeComponent();
            br = 0;
            Naslov.Text = "";            
            timer1.Interval = 90;            
            timer1.Start();
            DoubleBuffered = true;
            igrach = "";
            igg = tbName.Text;
            player = igg;
           
            bmp = new Bitmap(Resources.unmuteKonecna, pbMute.Size);
            bmp.MakeTransparent();
            pbMute.BackgroundImage = bmp;
            song = new SoundPlayer(Resources.pesna);
            play = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (br == ime.Length)
            {
                timer1.Stop();   
            }
            else
            {
                Naslov.Text += ime[br];
                br++;
            }
            
        }

        private void NewGame_MouseEnter(object sender, EventArgs e)
        {
            NewGame.BackColor=Color.SandyBrown;
        }

        private void NewGame_MouseLeave(object sender, EventArgs e)
        {
            NewGame.BackColor = Color.Gold;
        }

        private void FruitSaladButton_MouseEnter(object sender, EventArgs e)
        {
            FruitSaladButton.BackColor = Color.SandyBrown;
        }

        private void FruitSaladButton_MouseLeave(object sender, EventArgs e)
        {
            FruitSaladButton.BackColor = Color.Gold;
        }

        private void Help_MouseEnter(object sender, EventArgs e)
        {
            Help.BackColor = Color.SandyBrown;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            Help.BackColor = Color.Gold;
        }

        private void QuitB_MouseEnter(object sender, EventArgs e)
        {
            QuitB.BackColor = Color.SandyBrown;
        }

        private void QuitB_MouseLeave(object sender, EventArgs e)
        {
            QuitB.BackColor = Color.Gold;
        }

        private void QuitB_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure that you want to quit the game?", "Quit", MessageBoxButtons.YesNoCancel);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {

            nbIgra = 1;
            lHighScore.Show();
            panelStart.Show();
            PHighScore.Hide();
           
           
        }
        

        private void tbName_MouseClick(object sender, MouseEventArgs e)
        {

            tbName.Clear();
           
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            igrach = tbName.Text.Trim() ;
            lHighScore.Show();
            if (igrach.Length > 0)
            {
                if (nbIgra == 1)
                {
                    GlavnaIgra glavna = new GlavnaIgra(igrach);
                    this.Hide();
                    if (glavna.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Show();
                    }

                }
               
                            
            }
            else
            {
                MessageBox.Show("You have to insert your name!");
            }
            tbName.Clear();
        }




        private void Help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            lHighScore.Hide();
            this.Hide();

            if (help.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void FruitSaladButton_Click(object sender, EventArgs e)
        {
            nbIgra = 2;
            lHighScore.Show();
            FruitSaladGame glavna = new FruitSaladGame();
            this.Hide();
            if (glavna.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
            PHighScore.Hide();
        }


        private void pbPehar_Click(object sender, EventArgs e)
        {
            TextReader tr = new StreamReader("HighScores.txt");
            StringBuilder sb = new StringBuilder();
            String k = "";
            while ((k=tr.ReadLine()) != null)
            {
                sb.Append(k+"\n");
            }
            panelStart.Hide();
            PHighScore.Location = new Point(428, 168);
            PHighScore.Show();
            LblHighScore.Text = "";
            LblHighScore.Text = sb.ToString();
            lHighScore.Hide();
            tr.Close();
        }

        private void pbMute_Click(object sender, EventArgs e)
        {
            if (play)
            {
                bmp = new Bitmap(Resources.unmuteKonecna, new Size(pbMute.Width - 5, pbMute.Height));
                bmp.MakeTransparent();
                pbMute.BackgroundImage = bmp;
                song.Stop();
            }
            else
            {
                bmp = new Bitmap(Resources.muteKonecna, pbMute.Size);
                bmp.MakeTransparent();
                pbMute.BackgroundImage = bmp;
                song.PlayLooping();
            }
            play = !play;

        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartGame.PerformClick();
            }
        }

   

   
    }
}
