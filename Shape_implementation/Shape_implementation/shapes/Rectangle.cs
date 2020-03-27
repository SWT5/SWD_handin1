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
        public double Area { get; set; }
        public void draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
        public double CalcArea()
        {
            Area = 2 * 2;
           
            return Area;
        }

    }
}
