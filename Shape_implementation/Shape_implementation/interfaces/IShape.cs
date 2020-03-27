using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_implementation.interfaces
{
    public interface IShape
    {
        double Area { get; set; }
        void draw();
        double CalcArea();
    }
}
