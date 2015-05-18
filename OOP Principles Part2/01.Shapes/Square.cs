using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    // Define class Square 
    class Square : Shape
    {
        public Square(double hight)
            : base(hight, hight)
        {
        }
        public override double CalculateSurface()
        {
            return this.Height * this.Height;
        }
    }
}
