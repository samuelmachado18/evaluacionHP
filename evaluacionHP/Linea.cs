using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacionHP
{
    public class Linea : figura
    {
        public int X1, Y1, X2, Y2;
        public Color ColorLinea;

        public Linea(int x1, int y1, int x2, int y2, Color color) : base(color)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            ColorLinea = color;
        }

        public override void Dibujar(Graphics g)
        {
            using (Pen pen = new Pen(ColorLinea, 2))
            {
                g.DrawLine(pen, X1, Y1, X2, Y2);
            }
        }

        public override bool EstaDentro(Rectangle area)
        {
            return area.Contains(X1, Y1) && area.Contains(X2, Y2);
        }
    }
}
