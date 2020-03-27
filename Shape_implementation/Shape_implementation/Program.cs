using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape_implementation.abstract_class;
using Shape_implementation.Decorators;
using Shape_implementation.implementation;
using Shape_implementation.interfaces;

namespace Shape_implementation
{
    class Program
    { 
    static void Main(string[] args)
        {
            string _string;
            int _shapeType = 0;
            bool _boorderAdded = false;
            bool _colorAdded = false; 
            IShape _circle = new Circle();
            IShape _rectangle = new Rectangle();
            IShape _redRectangle = null; 
            IShape _redCircle = null;

            IShape _boldRedRectangle = null;
            IShape _boldRedCircle = null; 
            Console.WriteLine("Do you wish to create a Circle or Rectangle");
            Console.WriteLine("Type 'C' for Circle and 'R' for Rectangle ");
            _string = Console.ReadLine();
           
            do
            {
                if (_string == "R")
                {
                    
                    _rectangle = new Rectangle();
                    _shapeType = 1;
                }
                else if (_string == "C")
                {
                    _circle = new Circle();
                    _shapeType = 2;
                }
                else
                {
                    Console.WriteLine("Please choose a real pattern");
                    _string = Console.ReadLine();
                }
            } while (_string != "R" && _string != "C");

            Console.WriteLine("Do you wish to add a red border to your shape");
            Console.WriteLine("Press 'Y' for yes or 'N' for no");
            _string = Console.ReadLine();
            if (_string == "Y" && _shapeType == 1)
            {
                _redRectangle = new RedShapeDecorator(_rectangle);
                _colorAdded= true;
                _redRectangle.draw();
            }
            else if (_string == "Y" && _shapeType == 2)
            {
                _redCircle = new RedShapeDecorator(_circle);
                _colorAdded= true;
                _redCircle.draw();
            }
            else
            {
                Console.WriteLine("No red border added");
                if (_shapeType == 1)
                {
                    _rectangle.draw();
                    _colorAdded = false;
                }
                else
                {
                    _circle.draw();
                    _colorAdded = false;
                }
            }

            //do nothing 
            Console.WriteLine("Do you wish to make lines bold");
            Console.WriteLine("Press 'Y' for yes or 'N' for no");
            _string = Console.ReadLine();
            if (_string == "Y" && _shapeType == 1 && _colorAdded == true)
            {
                _boldRedRectangle = new BoldStyleDecorator(_redRectangle);
                _boldRedRectangle.draw();
            }
            else if (_string == "Y" && _shapeType == 2 && _colorAdded == true)
            {
                _boldRedCircle = new BoldStyleDecorator(_redCircle);
                _boldRedCircle.draw();
            }
            else
            {
                Console.WriteLine("Line style unchanged");
            }

        }
    }
}
