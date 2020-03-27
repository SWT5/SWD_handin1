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
        public double area { get; set; }
        public void draw()
        {
            Console.WriteLine("Shape: Circle");
        }
        public void CalcArea()
        {
            area = 3.14 * Math.Pow(1, 2);
            Console.WriteLine("Default area is: {0}", area);
        }

    }
}
