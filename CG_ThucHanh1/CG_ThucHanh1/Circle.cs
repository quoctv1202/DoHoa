using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_ThucHanh1
{
    class Circle : GraphicsBase
    {
        private int m_radius;

        public int Radius
        {
            get { return m_radius; }
            set { m_radius = value; }
        }
        
        public Circle()
        {
            this.Position = new Point(100, 100);
            this.Radius = 100;
        }

        public Circle(Point p, int r)
        {
            this.Position = p;
            this.Radius = r;
        }
        
        public override void frameMove(double totalTime, double timeElapse)
        {
            //base.frameMove(totalTime, timeElapse); 
            
            while (totalTime - timeElapse > 0)
            {
                
            }

        }

        public override void Draw(Graphics g, Pen p)
        {
            g.Clear(Color.White);
            g.DrawEllipse(p, Position.X, Position.Y, Radius, Radius);
        }


    }
}
