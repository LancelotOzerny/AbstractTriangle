using System;
using System.Windows.Forms;

namespace AbstractTriangle
{
    public class RectangularTriangle : Triangle
    {
        public override double Area()
        {
            return 0.5 * SideA * SideB * Math.Sin(Angle * Math.PI / 180);
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}