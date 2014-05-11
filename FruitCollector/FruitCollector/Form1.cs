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

        public Form1()
        {
            InitializeComponent();
            //TextReader tr = new StreamReader("Dokument.txt");
            //MessageBox.Show(tr.ReadLine() + "");
            br = 0;
            Naslov.Text = "";            
            timer1.Interval = 90;            
            timer1.Start();
            DoubleBuffered = true;
            igrach = "";
            igg = tbName.Text;
            player = igg;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

           // GlavnaIgra glavna = new GlavnaIgra();
           // this.Hide();
           // glavna.Show();
            nbIgra = 1;
            panelStart.Show();
           
           // player = tbName.Text;
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            //generateFruits();
           // Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(Color.Gold);
           // fruits.Draw(e.Graphics);
        }

        private void tbName_MouseClick(object sender, MouseEventArgs e)
        {

            tbName.Clear();
           
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            igrach = tbName.Text.Trim() ;
            if (igrach.Length > 0)
            {
                if (nbIgra == 1)
                {
                    GlavnaIgra glavna = new GlavnaIgra(igrach);
                  //  GlavnaIgra glavna = new GlavnaIgra(tbName.Text);
                    this.Hide();
                    //help.ShowDialog();
                    if (glavna.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Show();
                    }

                }
                if (nbIgra == 2)
                {
                    FruitSaladGame glavna = new FruitSaladGame();
                    this.Hide();
                    if (glavna.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                    //glavna.Show();
                }
               
                //4this.Hide();
                //this.Visible = false;
                //Form1.ActiveForm.Visible = false;
            }
            else
            {
                MessageBox.Show("You have to insert your name hane banane!");
            }
        }

        private void StartGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartGame_Click(sender, e);
            }
        }

        private void tbName_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            this.Hide();
            //help.ShowDialog();
            if (help.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void FruitSaladButton_Click(object sender, EventArgs e)
        {
            nbIgra = 2;
            panelStart.Show();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pbPehar_Click(object sender, EventArgs e)
        {
            TextReader tr = new StreamReader("Dokument.txt");
            MessageBox.Show(tr.ReadLine()+"");
           // high.Text = tr.ReadLine() + "pts";
        }

   
    }
}
