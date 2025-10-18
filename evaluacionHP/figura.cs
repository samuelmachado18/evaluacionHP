using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacionHP
{
        public abstract class figura
        {
            public Color Color { get; set; }

            protected figura(Color color)
            {
                Color = color;
            }

            public abstract void Dibujar(Graphics g);

            public abstract bool EstaDentro(Rectangle diseño);
        }
    
}
