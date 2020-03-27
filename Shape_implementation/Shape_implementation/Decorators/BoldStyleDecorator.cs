using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape_implementation.abstract_class;
using Shape_implementation.interfaces;


namespace Shape_implementation.Decorators
{
    public class BoldStyleDecorator : ShapeDecorator
    {
        private IShape _shape;
        public BoldStyleDecorator(IShape shape)
        {
            _shape = shape;
        }

        //override the other other draws to set border (ShapeDecorator has to be abstract to use override)
        public override void draw()
        {
            _shape.draw();      //printing out the shape
            lineStyle();
        }

        private void lineStyle()
        {
            Console.WriteLine("Border style: Bold");
        }

        private void CalcArea()
        {
            double _area = (_shape.area) * 0.9;
            Console.WriteLine("Default area is: {0}", _area);
        }
    }

}

