using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacionHP
{
    public class Triangulo : figura
    {
        public Point A, B, C;
        public Color ColorRelleno;

        public Triangulo(Point a, Point b, Point c, Color color) : base(color)
        {
            A = a;
            B = b;
            C = c;
            ColorRelleno = color;
        }

        public override void Dibujar(Graphics g)
        {
            Point[] puntos = { A, B, C };

            using (Brush brush = new SolidBrush(ColorRelleno))
            {
                g.FillPolygon(brush, puntos);
            }

            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawPolygon(pen, puntos);
            }
        }

        public override bool EstaDentro(Rectangle area)
        {
            return area.Contains(A) && area.Contains(B) && area.Contains(C);
        }
    }
}
