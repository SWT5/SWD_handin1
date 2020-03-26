﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape_implementation.interfaces;

namespace Shape_implementation.abstract_class
{

    //abstract class
    public class ShapeDecorator : IShape
    {
        protected IShape _shape;

        public ShapeDecorator()
        {

        }

        public virtual void draw()
        {
            _shape.draw();
        }
    }
}