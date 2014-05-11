using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FruitCollector.Properties;
namespace FruitCollector
{
    class Koshnica
    {
        Bitmap koshnichka; 
        public int X { get; set; } 
        public int Y { get; set; } 
        public int widthK { get; set; } 
        public int heightH { get; set; }
        public double speed = 40;
        public double velocity = 120;
        public Koshnica(int width,int height) 
        {
            koshnichka = Resources.kosnicka;            
            koshnichka.MakeTransparent();
            widthK = 150;
            heightH = 50;
            X = width/2-widthK/2;
            Y = height-4*heightH+100; 
            
        }
        public void Draw(Graphics g)
        { 
            g.DrawImage(koshnichka, X, Y,widthK,heightH);
        } 
        public double getVx()
        {
            return speed * Math.Acos(velocity * Math.PI / 180);
        }
        public double getVy()
        {
            return speed * Math.Asin(velocity * Math.PI / 180);
        }
        public void Namali()
        { 
            
        }

    }
}
