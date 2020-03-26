using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape_implementation.abstract_class;
using Shape_implementation.implementation;
using Shape_implementation.interfaces;

namespace Shape_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            IShape rectangle = new Rectangle();

            IShape redRectangle = new RedShapeDecorator(new Rectangle());
            IShape redCircle = new RedShapeDecorator(new Circle());

            circle.draw();
            rectangle.draw();

            Console.WriteLine("");
            Console.WriteLine("");

            redRectangle.draw();
            Console.WriteLine("");
            redCircle.draw();
            Console.WriteLine("");



        }
    }
}
