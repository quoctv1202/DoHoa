using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_ThucHanh1
{
    class GraphicsBase
    {
        protected Point m_Position;

        public Point Position
        {
            get { return m_Position; }
            set { m_Position = value; }
        }

        private Color m_color;

        public Color Color
        {
            get { return m_color; }
            set { m_color = value; }
        }

        public GraphicsBase()
        {
            m_Position = new Point(100, 100);
            m_color = Color.Red;
        }

        ~GraphicsBase() { }

        public virtual void frameMove(double totalTime, double timeElapse) { }

        public virtual void Draw(Graphics g, Pen p) { }
    }
}
