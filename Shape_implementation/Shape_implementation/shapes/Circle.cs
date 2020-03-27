using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape_implementation.interfaces;


namespace Shape_implementation.implementation
{
    public class Circle : IShape
    {
        public double Area { get; set; }
        public void draw()
        {
            Console.WriteLine("Shape: Circle");
        }
        public double CalcArea()
        {
            Area = 3.14 * Math.Pow(1, 2);
            return Area;
        }

    }
}
