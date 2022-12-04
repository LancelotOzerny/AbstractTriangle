using System;

namespace AbstractTriangle
{
    /// <summary>
    /// Класс равнобедренного треугольника
    /// </summary>
    public class IsoscelesTriangle : Triangle
    {
        public override double Area()
        {
            return 0.5 * SideA * SideA * Math.Sin(Angle * Math.PI / 180);
        }

        public override double Perimeter()
        {
            return 2 * SideA + SideC;
        }
    }
}
