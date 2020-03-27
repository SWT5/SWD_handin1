using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape_implementation.interfaces;

namespace Shape_implementation.abstract_class
{

    //abstract class
    public abstract class ShapeDecorator : IShape
    {
        protected IShape _shape;
        public double Area { get; set; }

        public virtual void draw()
        {
            _shape.draw();
        }

        public virtual double CalcArea()
        {
            return _shape.CalcArea();
        }

    }
}
