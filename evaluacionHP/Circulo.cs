using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace evaluacionHP
{
    public class Circulo : figura
    {
        public int X, Y, Radio;


        public Circulo(int x, int y, int radio, Color color) : base(color)
        {
            X = x;
            Y = y;
            Radio = radio;
            this.Color = color;
        }

        public override void Dibujar(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillEllipse(brush, X, Y, Radio * 2, Radio * 2);
            }

            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawEllipse(pen, X, Y, Radio * 2, Radio * 2);
            }
        }

        public override bool EstaDentro(Rectangle area)
        {
            return area.Contains(X, Y) && area.Contains(X + Radio * 2, Y + Radio * 2);
        }
    }
}
