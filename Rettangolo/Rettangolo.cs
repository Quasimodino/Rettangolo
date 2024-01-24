using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo
{
    internal class Rettangolo
    {
        public double latomaggiore { get; set; }
        public double latominore { get; set; }
        public double area()
        {
            double area;
            area = latomaggiore * latominore;
            return area;
        }
        public double perimetro()
        {
            double perimetro;
            perimetro= latomaggiore*2+latominore*2;
            return perimetro;
        }
    }
}
