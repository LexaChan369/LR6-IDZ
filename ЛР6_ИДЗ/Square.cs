using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6_ИДЗ
{
    internal class Square:Geometry,IPerimeter
    {
        private double side;
        public Square(double side, string name)
        {
            this.side = side;
            this.name = name;
        }

        public override double GetPerimeter()
        {
            return side * 4;
        }

    }
}
