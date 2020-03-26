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
        public void draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
