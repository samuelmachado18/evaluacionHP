using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacionHP
{
    public static class figuraFactory
    {
        public static figura CrearFigura(string tipo, int ejeX, int ejeY, int ejeX2, int ejeY2, int ancho, int largo, Color color)
        {
            if (color == null)
                throw new ArgumentException("Debe seleccionar un color válido.");

            switch (tipo)
            {
                case "Rectangulo":
                    if (ancho <= 0 || largo <= 0)
                        throw new ArgumentException("El ancho y el largo deben ser mayores que cero.");
                    return new Rectangulo(ejeX, ejeY, ancho, largo, color);

                case "Circulo":
                    if (ancho <= 0)
                        throw new ArgumentException("El radio del círculo debe ser mayor que cero.");
                    return new Circulo(ejeX, ejeY, ancho, color);

                case "Triangulo":
                    if ((ejeX == ejeX2 && ejeY == ejeY2) || (ancho == 0 && largo == 0))
                        throw new ArgumentException("Los puntos del triángulo no pueden ser iguales y las dimensiones deben ser mayores que cero.");
                    Point p1 = new Point(ejeX, ejeY);
                    Point p2 = new Point(ejeX2, ejeY2);
                    Point p3 = new Point(ejeX + ancho, ejeY + largo);
                    return new Triangulo(p1, p2, p3, color);

                case "Linea":
                    if (ejeX == ejeX2 && ejeY == ejeY2)
                        throw new ArgumentException("Los puntos de la línea no pueden ser iguales.");
                    return new Linea(ejeX, ejeY, ejeX2, ejeY2, color);

                default:
                    throw new ArgumentException("Tipo de figura no válido.");
            }
        }
    }
}
