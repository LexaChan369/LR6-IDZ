using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6_ИДЗ
{
    internal class Triangle:Geometry,IPerimeter
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3, string name)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.name = name;
        }

        public override double GetPerimeter()
        {
            return side1+side2+side3;
        }
    }
}
