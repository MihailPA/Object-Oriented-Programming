using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    using System;
    class TestShapes
    {
        static void Main()
        {
            var testShapes = new Shape[]
            {
                new Triangle(12.5 , 4.5),
                new Triangle(3 , 8.3),

                new Square(4),
                new Square(4.65),

                new Rectangle(2.5, 10),
                new Rectangle(4, 3.45),
            };

            foreach (var shapes in testShapes)
            {
                Console.WriteLine(string.Format("{0} has a surface of {1}"
                    , shapes.GetType().Name, shapes.CalculateSurface()));
            }

            Console.WriteLine();
        }
    }
}
