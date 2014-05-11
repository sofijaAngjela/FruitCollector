using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

using System.Runtime.Serialization.Formatters.Binary;
using FruitCollector.Properties;


namespace FruitCollector
{
    public class Fruit
    {
        public static readonly int RADIUS = 30;

        public bool goodOrBad { get; set; }
        public int Misses { get; set; }
        public int State { get; set; }
        public Point Center { get; set; }
        Random r = new Random();
        public Bitmap bmp;
        public int k { get; set; }
        public Fruit()
        {

            State = r.Next(0, 6);
            goodOrBad = false;
            List<Bitmap> lista = new List<Bitmap>();
            Bitmap bm1 = Resources.Bitmap1;
            bm1.MakeTransparent();
            Bitmap bm2 = Resources.Bitmap2;
            bm2.MakeTransparent();
            Bitmap bm3 = Resources.Bitmap3;
            bm3.MakeTransparent();
            Bitmap bm4 = Resources.Bitmap4;
            bm4.MakeTransparent();
            Bitmap bm5 = Resources.Bitmap5;
            bm5.MakeTransparent();
            Bitmap bm6 = Resources.Bitmap6;
            bm6.MakeTransparent();
            Bitmap bm7 = Resources.Bitmap7;
            bm7.MakeTransparent();
            Bitmap bm8 = Resources.Bitmap8;
            bm8.MakeTransparent();
            lista.Add(bm1);
            lista.Add(bm2);
            lista.Add(bm3);
            lista.Add(bm4);
            lista.Add(bm5);
            lista.Add(bm6);
            lista.Add(bm7);
            lista.Add(bm8);
            
            bmp = lista.ElementAt(k = r.Next(lista.Count));
            if (k == 1 || k==2 || k==4 || k==6)
            {
                goodOrBad = true;
            }
            else
            {
                goodOrBad = false;
            }
        }


        public void Move()
        {
            Center = new Point(Center.X, Center.Y + 10);
        }

        public void Draw(Graphics g)
        {


            g.DrawImage(bmp, Center.X , Center.Y);


        }
        public bool Catch(Point tocka,int kosnicaWidth)
        {
            if ((Center.Y + bmp.Height >= tocka.Y) && (Center.Y + bmp.Height < tocka.Y+10) && (Center.X >= tocka.X - 5) && (Center.X + bmp.Width <= tocka.X + kosnicaWidth + 5))
            return true;
            else
                return false;
        }

    }
}
