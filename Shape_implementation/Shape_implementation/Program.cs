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
            IShape _doubleArea = null;

            IShape _boldRectangle = null;
            IShape _boldCircle = null; 
            Console.WriteLine("Do you wish to create a Circle or Rectangle");
            Console.WriteLine("Type 'C' for Circle and 'R' for Rectangle ");
            _string = Console.ReadLine();
           
            do
            {
                if (_string == "R")
                {
                    //_rectangle = new Rectangle();
                    _shapeType = 1;
                }
                else if (_string == "C")
                {
                    //_circle = new Circle();
                    _shapeType = 2;
                }
                else
                {
                    Console.WriteLine("Please choose a real pattern");
                    _string = Console.ReadLine();
                }
            } while (_string != "R" && _string != "C");

            Console.WriteLine("");
            Console.WriteLine("Do you wish to add a red border to your shape");
            Console.WriteLine("Press 'Y' for yes or 'N' for no");
            _string = Console.ReadLine();
            if (_string == "Y" && _shapeType == 1)
            {
                _redRectangle = new RedShapeDecorator(_rectangle);
                _colorAdded= true;
                _redRectangle.draw();
                _redRectangle.CalcArea();
            }
            else if (_string == "Y" && _shapeType == 2)
            {
                _redCircle = new RedShapeDecorator(_circle);
                _colorAdded= true;
                _redCircle.draw();
                _redCircle.CalcArea();
            }
            else
            {
                Console.WriteLine("No red border added");
                if (_shapeType == 1)
                {
                    _rectangle.draw();
                    _rectangle.CalcArea();
                    _colorAdded = false;
                }
                else
                {
                    _circle.draw();
                    _circle.CalcArea();
                    _colorAdded = false;
                }
            }

            Console.WriteLine("Do you wish to make lines bold");
            Console.WriteLine("Press 'Y' for yes or 'N' for no");
            _string = Console.ReadLine();
            if (_string == "Y" && _shapeType == 1 && _colorAdded == true)
            {
                _boldRectangle = new BoldStyleDecorator(_redRectangle);
                _boldRectangle.draw();
                _boldRectangle.CalcArea();
            }
            else if (_string == "Y" && _shapeType == 2 && _colorAdded == true)
            {
                _boldCircle = new BoldStyleDecorator(_redCircle);
                _boldCircle.draw();
                _boldCircle.CalcArea();
            }
            else if (_string == "Y" && _shapeType == 1 && _colorAdded == false)
            {
                _boldRectangle = new BoldStyleDecorator(_rectangle);
                _boldRectangle.draw();
                _boldRectangle.CalcArea();
            }
            else if (_string == "Y" && _shapeType == 2 && _colorAdded == false)
            {
                _boldCircle = new BoldStyleDecorator(_circle);
                _boldCircle.draw();
                _boldCircle.CalcArea();
            }
            else
            {
                Console.WriteLine("No bold style added");
            }

            //Console.WriteLine("Example of calling decorators in different orders");
            //Console.WriteLine("");
            //Console.WriteLine("Double the size before you add bord bold");

            
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("Double the size after adding bold style");
           


        }
    }
}
