using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTriangle
{
    public class EquilateralTriangle : Triangle
    {
        /*
    В классе все стороны равны. Поэтому реализуем геттеры сторон
    Каждая сторона при изменении будет менять другие
*/

        /// <summary>
        /// Свойство, которое  позволяет получить или установить значение стороны А треугольника
        /// </summary>
        public override double SideA
        {
            get => _sideA;
            set => SetSide(value);
        }

        /// <summary>
        /// Свойство, которое позволяет получить значение угла треугольника
        /// </summary>
        public override double Angle
        {
            get => 30;
        }

        /// <summary>
        /// Свойство, которое  позволяет получить или установить значение стороны А треугольника
        /// </summary>
        public override double SideB
        {
            get => _sideB;
            set => SetSide(value);
        }

        /// <summary>
        /// Свойство, которое  позволяет получить или установить значение стороны А треугольника
        /// </summary>
        public override double SideC
        {
            get => _sideС;
            set => SetSide(value);
        }

        public override double Area()
        {
            return (System.Math.Sqrt(3) * SideA * SideA) / 4;
        }

        public override double Perimeter()
        {
            return SideA * 3;
        }

        /// <summary>
        /// Свойство, которое устанавливает всем сторонам треугольника передаваемое значение
        /// </summary>
        /// <param name="value"></param>
        private void SetSide(double value)
        {
            _sideA = value;
            _sideB = value;
            _sideС = value;
        }
    }
}
