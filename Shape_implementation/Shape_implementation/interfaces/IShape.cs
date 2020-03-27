using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_implementation.interfaces
{
    public interface IShape
    {
        double area { get; set; }
        void draw();
        void CalcArea();
    }
}
