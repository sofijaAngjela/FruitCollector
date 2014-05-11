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
    public class FruitList
    {
        public List<Fruit> fruits { get; set; }
        public int Koja { get; set; }
        public int Hits { get; set; }
        public int Missed { get; set; }
        public bool Paused { get; set; }
        public int jagodi { get; set; }
        public int banani { get; set; }
        public int kryshi { get; set; }
        public int jabolka { get; set; }
        public int Nezdrava { get; set; }
        public FruitList()
        {
            fruits = new List<Fruit>();
            Hits = 0;
            Nezdrava = 0;
            Missed = 0;
            Paused = false;
        }

        public void addFruit(Point center)
        {
            Fruit f = new Fruit();
            f.Center = center;
            fruits.Add(f);
        }


        public void Move(int width,int x,int y,int sirina)
        {
            for (int i = fruits.Count - 1; i >= 0; i--)
            {
                if (Check(fruits[i], new Point(x,y), sirina))
                {
                    //MessageBox.Show(fruits[i].k + "");
                    if (fruits[i].k == 1)
                    {
                        jabolka--;
                        //MessageBox.Show(fruits[i].k + "");
                       
                    }
                    if (fruits[i].k == 2)
                    {
                        banani--;
                    }
                    if (fruits[i].k == 4)
                    {
                        kryshi--;
                    }
                    if (fruits[i].k == 6)
                    {
                        jagodi--;
                    }
                    if (fruits[i].goodOrBad == true)
                    {
                        Hits++;
                    }
                    else
                    {
                        Missed++;
                        Nezdrava++;
                    }
                    fruits.Remove(fruits[i]); 
                }              
            }
                foreach (Fruit f in fruits)
                {
                    f.Move();
                    if (f.Center.X > width + Fruit.RADIUS)
                    {
                        f.State = -1;
                    }
                }
       /*     for (int i = fruits.Count - 1; i >= 0; --i)
            {
                if (fruits[i].State == -1)
                {
                    fruits.RemoveAt(i);
                    Missed++;
                }
            }*/
        }
        public bool Check(Fruit f,Point kosnica,int sirina)
        {
            return f.Catch(kosnica,sirina);
        }
        public void Draw(Graphics g)
        {
            foreach (Fruit f in fruits)
            {
                f.Draw(g);
            }
        }
    }
}

