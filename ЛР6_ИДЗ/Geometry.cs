using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6_ИДЗ
{
    internal class Geometry: IPerimeter
    {
        protected string name;
       public virtual double GetPerimeter()
        {
            return 0;
        }

        public string GetInfo()
        {
            return name;
        }
    }
}
