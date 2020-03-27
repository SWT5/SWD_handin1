using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape_implementation.abstract_class;
using Shape_implementation.interfaces;

namespace Shape_implementation.implementation
{
    public class RedShapeDecorator : ShapeDecorator
    {
        private IShape _shape;
        public RedShapeDecorator(IShape shape)
        {
            _shape = shape;
        }

        //override the other other draws to set border (ShapeDecorator has to be abstract to use override)
        public override void draw()
        {
            _shape.draw();      //printing out the shape
            setRedborder();
        }

        private void setRedborder()
        {
            Console.WriteLine("Border color: Red");
        }

        public override double CalcArea()
        {
            return _shape.CalcArea();
        }
    }
}
