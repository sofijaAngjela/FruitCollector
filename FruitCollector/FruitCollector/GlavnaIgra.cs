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
    public partial class GlavnaIgra : Form
    {
        
        int countDown = 3;
        public FruitList fruits;
        public int generateFruit;
        public Random r;
        Koshnica koshnica;
        List<Bitmap> lista;
        //static int vkypnoZhivoti = 5;
        int zivoti;
        Bitmap smajli;
        public string igrach1 { get; set; }
        public GlavnaIgra(String igrach)
        {
            InitializeComponent();
            igrach1 = igrach;
           
            vnesiIme.Text = Form1.player;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            FinalCountDown.Text = "";
            timer1.Start();
            fruits = new FruitList(); 
            koshnica = new Koshnica(this.Width,this.Height);
            generateFruit = 0;
            DoubleBuffered = true;
            r = new Random();
            lista = new List<Bitmap>();
            lista.Add(Resources.smajli);
            zivoti = 5;
            smajli = Resources.smajli;
            smajli.MakeTransparent();
           
        }

        private void GlavnaIgra_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            FinalCountDown.Text = countDown + "";
            
            if (countDown == 0)
            {
                FinalCountDown.Hide();
                timer1.Stop();
                
                this.KeyPreview = true;
                timer2.Start();
                timer3.Start();
                timer3.Interval = 200;
           

            }
            countDown--;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            generateFruits();
            Invalidate(true);
        }
        public void azuriranjePogodoci()
        {
            lHitss.Text = fruits.Hits.ToString();
            lPoints1.Text = (fruits.Hits*10 - fruits.Missed * 5)+"";
            if (zivoti > 0)
            {
              
                zivoti = 5-fruits.Missed;
                //MessageBox.Show(fruits.Missed+"");
            }
            else
                if (zivoti == 0)
                {
                    timer2.Stop();
                    timer3.Stop();
                    IgrajPak.Show();
                    Ime1.Text = vnesiIme.Text+": ";
                    Poeni.Text = lPoints1.Text;
                    if (fruits.Hits < 20)
                    {
                        Komentar.Text = "Ooops! You've got poisoned.I didn't know fruit can kill so easily :P";
                    }
                    else
                        if (fruits.Hits < 60)
                        {
                            Komentar.Text = "Ooops! You've got poisoned.Not that bad... at losing";
                        }
                        else
                            if (fruits.Hits < 200)
                            {
                                Komentar.Text = "Great job ... But not the best!!";
                            }
                            else
                                if (fruits.Hits < 400)
                                {
                                    Komentar.Text = "You're surprising me ...";
                                }
                                else
                                    if (fruits.Hits >= 400)
                                    {
                                        Komentar.Text = "Is that Athene ? ";
                                    }
                }

        }
        private void GlavnaIgra_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Resources.grassZasekoga66KRAJ,new Point(Width,Height));
            koshnica.Draw(e.Graphics);
            fruits.Draw(e.Graphics);
            vnesiIme.Text = igrach1;
            for (int i = 0; i < zivoti; i++)
            {

                e.Graphics.DrawImage(smajli, Resources.smajli.Width * (i + 1) + (Width - Resources.smajli.Width * zivoti)-3*label2.Width, 10, 30, 30);
           
            }
            azuriranjePogodoci();
        }

        private void GlavnaIgra_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Right == e.KeyCode)
            {

              if(koshnica.X+12+koshnica.widthK>=this.Width-20)
              {
                  koshnica.X = this.Width - koshnica.widthK-20;
                  //koshnica.getVy();
              }
              else
              {
                    koshnica.X+=12;
                    
              }
            }
            if (Keys.Left == e.KeyCode)
            {
                if (koshnica.X - 12 <= 0)
                {
                    koshnica.X =  0;
                   // koshnica.getVx();
                }
                else
                {
                    koshnica.X -= 12;
                   
                }
            }
        }

        private void GlavnaIgra_Load(object sender, EventArgs e)
        {

        }
        private void AzhyrirajPogodoci()
        { 
            
        
        }


        private void GlavnaIgra_Resize(object sender, EventArgs e)
        {
            koshnica.Y = Height - 4 * koshnica.heightH + 100;
        }

        private void lHitss_Click(object sender, EventArgs e)
        {
           
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            generateFruits();
            if (int.Parse(lHitss.Text) > 50)
            {
                timer3.Interval = 10;
            }
            else if (int.Parse(lHitss.Text) > 40)
            { 
                timer3.Interval = 40; 
            }
            else if (int.Parse(lHitss.Text) > 25)
            {
                timer3.Interval = 55;
            }
            else if (int.Parse(lHitss.Text) > 15)
            { 
                timer3.Interval = 70; 
            }
            else if (int.Parse(lHitss.Text) == 10 && int.Parse(lHitss.Text) > 0)
            {
                timer3.Interval = 80; 
            }
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            GlavnaIgra g = new GlavnaIgra(igrach1);
            g.Show();
            this.Close();

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            //Form1.ActiveForm.ShowDialog();
            //Form1.ActiveForm.Visible = true;
            this.Close();

        }

        private void GlavnaIgra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'd')
            {

                if (koshnica.X + 12 + koshnica.widthK >= this.Width-20)
                {
                    koshnica.X = this.Width - koshnica.widthK;
                    //koshnica.getVy();
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
                    // koshnica.getVx();
                }
                else
                {
                    koshnica.X -= 12;

                }
            }
        }




    }

}
