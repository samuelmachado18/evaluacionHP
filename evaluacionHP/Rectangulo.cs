using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacionHP
{
    public class Rectangulo : figura
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public Rectangulo(int x, int y, int ancho, int alto, Color color)
            : base(color)
        {
            X = x;
            Y = y;
            Ancho = ancho;
            Alto = alto;
        }

        public override void Dibujar(Graphics g)
        {
            using (Pen p = new Pen(Color, 2))
            {
                g.DrawRectangle(p, X, Y, Ancho, Alto);
            }
        }

        public override bool EstaDentro(Rectangle diseño)
        {
            return X >= 0 && Y >= 0 &&
                   X + Ancho <= diseño.Width &&
                   Y + Alto <= diseño.Height;
        }

    }
}
