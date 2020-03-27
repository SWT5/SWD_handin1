using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape_implementation.abstract_class;
using Shape_implementation.interfaces;

namespace Shape_implementation.Decorators
{
    class DoubleSizeDecorator : ShapeDecorator
    {
        private IShape _shape;
        public DoubleSizeDecorator(IShape shape)
        {
            _shape = shape;
        }

        //override the other other draws to set border (ShapeDecorator has to be abstract to use override)
        public override void draw()
        {
            _shape.draw();      //printing out the shape
            
        }

        public override double CalcArea()
        {
            double _area = _shape.CalcArea()*2;
            Console.WriteLine("Area size doubled: {0}", _area);

            return _area;
        }
    }
}
