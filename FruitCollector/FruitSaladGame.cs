using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FruitCollector.Properties;

namespace FruitCollector
{
    public partial class FruitSaladGame : Form
    {
        public bool GenerateKliknato { get; set; }
        public int jagodi { get; set; }
        public int banani { get; set; }
        public int kryshi { get; set; }
        public int jabolka { get; set; }
        public FruitList fruits;
        public Random r;
        Koshnica koshnica;
        public int generateFruit;
        public int brojac = 10;
        Bitmap bmpKryshi;
        Bitmap bmpJabolki;
        Bitmap bmpJagodi;
        Bitmap bmpBanani;
        int i;
        bool flag;
        public FruitSaladGame()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            GenerateKliknato = false;
            generateFruit = 0;
            DoubleBuffered = true;
            r = new Random();
            fruits = new FruitList();
            koshnica = new Koshnica(this.Width, this.Height);
            generateFruit = 0;
            DoubleBuffered = true;
            flag = false;
            bmpBanani = Resources.Bitmap3;
            bmpJabolki = Resources.Bitmap2;
            bmpKryshi = Resources.Bitmap5;
            bmpJagodi = Resources.Bitmap7;
            bmpBanani.MakeTransparent();
            bmpJabolki.MakeTransparent();
            bmpJagodi.MakeTransparent();
            bmpKryshi.MakeTransparent();
        }

        public void check() {
            Game();
            if (flag == false)
            {
                timer2.Stop();
                timer1.Stop();
                igrajPak1.Location = new Point(216,32);
                komentar1.Text = "Ooops.. time's up :/ You lost !";
                igrajPak1.Show();

            }
            Invalidate(true);
            
        }
        public void Game()
        {
            if (fruits.jabolka <= 0 && fruits.jagodi <= 0 && fruits.kryshi <= 0 && fruits.banani <= 0)
            {
                timer2.Stop();
                timer1.Stop();
                igrajPak1.Location = new Point(216, 32);
                komentar1.Text = "You won :D";
                igrajPak1.Show();
            }
            if (fruits.Nezdrava == 5)
            {
                i += 100;
                fruits.Nezdrava = 0;
            }
        }
        public void generateFruits()
        {
            if (generateFruit % 10 == 0)
            {
                int y = r.Next(2 * Fruit.RADIUS, Width - (Fruit.RADIUS * 2));
                int x = -Fruit.RADIUS;
                fruits.addFruit(new Point(y, x));
            }
            generateFruit++;
            fruits.Move(Width, koshnica.X, koshnica.Y, koshnica.widthK);
        }


        private void Play_Click(object sender, EventArgs e)
        {

            if (GenerateKliknato == true)
            {
                GenerirajOvoshje.Visible = false;
                lblJagodi1.Text = lblJagodi.Text;
                lblBanani1.Text = lblBanani.Text;
                lblKryshi1.Text = lblKryshi.Text;
                lblJabolki1.Text = lblJabolki.Text;
                timer1.Start();
                timer2.Start();
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            GenerateKliknato = true;
            Sokrij.Visible = true;
            Izgeneriraj();
            fruits.jabolka = jabolka;
            fruits.jagodi = jagodi;
            fruits.kryshi = kryshi;
            fruits.banani = banani;
            lblJabolki.Text = "x " + jabolka;
            lblBanani.Text = "x " + banani;
            lblKryshi.Text = "x " + kryshi;
            lblJagodi.Text = "x" + jagodi;

           
        }
        public void AzhyrirajPodatoci()
        {
            if (fruits.jabolka <= -1)
            {
                lblJabolki1.Text = "x " + 0;
            }
            else
            {
                lblJabolki1.Text = "x " + fruits.jabolka;
            }
            if (fruits.banani <= -1)
            {
                lblBanani1.Text = "x " + 0;
            }
            else
            {
                lblBanani1.Text = "x " + fruits.banani;
            }
            if (fruits.kryshi <= -1)
            {
                lblKryshi1.Text = "x " + 0;
            }
            else
            {
                lblKryshi1.Text = "x " + fruits.kryshi;
            }
            if (fruits.jagodi <= -1)
            {
                lblJagodi1.Text = "x" + 0;
            }
            else
            {
                lblJagodi1.Text = "x" + fruits.jagodi;
            }
        }


        public void Izgeneriraj()
        {
            
            jabolka = 0;
            banani = 0;
            kryshi = 0;
            jagodi = 0;
            for (int i = 0; i < 30; i++)
            {
                int k = r.Next(0, 4);
                if (k == 0)
                {
                    jabolka++;
                }
                if (k == 1)
                {
                    banani++;
                }
                if (k == 2)
                {
                    kryshi++;
                }
                if (k == 3)
                {
                    jagodi++;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            generateFruits();
            check();
            Invalidate(true);
        }

        private void FruitSaladGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Resources.grassZasekoga66KRAJ, new Point(Width, Height));
            koshnica.Draw(e.Graphics);
            fruits.Draw(e.Graphics);
            if (i < 360)
            {
                e.Graphics.FillPie(new SolidBrush(Color.Gold), 10, 10, 80, 80, 270, i);
                flag = true;
            }
            else
            {
                flag = false;
            }
            if (GenerateKliknato == true)
            {  
                e.Graphics.DrawImage(bmpJabolki, Width-((4 * Resources.Bitmap2.Width) + (4 * lblBanani.Width)+40), 10, 30, 30);
                e.Graphics.DrawImage(bmpBanani,Width-((3 * Resources.Bitmap2.Width) + (3 * lblBanani.Width)+40), 10, 30, 30);
                e.Graphics.DrawImage(bmpKryshi,Width-((2 * Resources.Bitmap2.Width) + (2 * lblBanani.Width)+40), 10, 30, 30);
                e.Graphics.DrawImage(bmpJagodi, Width-((1 * Resources.Bitmap2.Width) + (1 * lblBanani.Width)+40), 10, 30, 30);
            }
            AzhyrirajPodatoci();
        }

        private void FruitSaladGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Right == e.KeyCode)
            {

                if (koshnica.X + 12 + koshnica.widthK >= this.Width - 20)
                {
                    koshnica.X = this.Width - koshnica.widthK - 20;
                }
                else
                {
                    koshnica.X += 25;

                }
            }
            if (Keys.Left == e.KeyCode)
            {
                if (koshnica.X - 12 <= 0)
                {
                    koshnica.X = 0;
                }
                else
                {
                    koshnica.X -= 25;

                }
            }
        }

        private void FruitSaladGame_Resize(object sender, EventArgs e)
        {
            koshnica.Y = Height - 4 * koshnica.heightH + 100;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i += 10;
            
            Invalidate();
        }

        private void PlayAgain1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            igrajPak1.Hide();
            GenerirajOvoshje.Show();
            i = 0;
            r = new Random();
            fruits = new FruitList();
            koshnica = new Koshnica(this.Width, this.Height);
            generateFruit = 0;
            flag = false;
            lblJabolki.Text = "x " + 0;
            lblBanani.Text = "x " + 0;
            lblKryshi.Text = "x " + 0;
            lblJagodi.Text = "x" + 0;
        }
        private void Quit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FruitSaladGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'd')
            {

                if (koshnica.X + 12 + koshnica.widthK >= this.Width - 20)
                {
                    koshnica.X = this.Width - koshnica.widthK;

                }
                else
                {
                    koshnica.X += 12;

                }
            }
            if (e.KeyChar == 'a')
            {
                if (koshnica.X - 12 <= 0)
                {
                    koshnica.X = 0;
                }
                else
                {
                    koshnica.X -= 12;

                }
            }
        }



    }
}
