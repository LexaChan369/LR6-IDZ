using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6_ИДЗ
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Perimeter<Geometry>.GetPer(new Triangle(26,62,42, "Треугольник")));
            Console.WriteLine(Perimeter<Geometry>.GetPer(new Square(4, "Квадрат")));
            Console.WriteLine(Perimeter<Geometry>.GetInfo(new Triangle(26, 62, 42, "Треугольник")));
            Console.WriteLine(Perimeter<Geometry>.GetInfo(new Square(4, "Квадрат")));
        }
    }
}
