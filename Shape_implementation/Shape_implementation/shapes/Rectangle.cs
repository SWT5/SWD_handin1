using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape_implementation.interfaces;

namespace Shape_implementation.implementation
{
    public class Rectangle : IShape
    {
        public double area { get; set; }
        public void draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
        public void CalcArea()
        {
            area = 2 * 2;
            Console.WriteLine("Default area is: {0}", area);
        }
    }
}
