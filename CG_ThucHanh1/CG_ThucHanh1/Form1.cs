using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_ThucHanh1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black);
        Constant.Animation m_animation;
        int x;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            g= pbxMain.CreateGraphics();
            g.Clear(Color.White);
            int x = 100, y = 100, r = 50;
            while (true)
            {
                g.Clear(Color.White);
                g.DrawEllipse(p, x, y, r, r);
                int move = 1;
                if (x>(400))
                {
                    break;
                }
                x += move;
                
                System.Threading.Thread.Sleep(1);
            }
            g.Dispose();
        }

        private void btnCircleMove_Click(object sender, EventArgs e)
        {
            x = 1;
            timer1.Interval = 100;
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x==1)
            {
                draw_Circle();
            }
            else if(x==2)
            {
                timer1.Stop();
            }
        }

        private void draw_Circle()
        {
            //tao bo dem bitmap moi
            Bitmap bm = new Bitmap(pbxMain.Width, pbxMain.Height);
            g = Graphics.FromImage(bm);
            //clearScr
            g.Clear(Color.White);
            //dr
            Circle circle = new Circle(new Point(100, 100), 100);
            circle.Draw(g, p);
            pbxMain.Image = bm;

            //update
            circle.Position = new Point(circle.Position.X + 5, circle.Position.Y + 5);
            if (circle.Position.X > 300)
            {
                x = 2;
            }
            //dispose
            g.Dispose();
        }
    }
}
