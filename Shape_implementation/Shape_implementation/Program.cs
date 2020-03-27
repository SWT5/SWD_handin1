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
            bool _bold = false;
            IShape _circle = new Circle();
            IShape _rectangle = new Rectangle();
            IShape _redRectangle = null; 
            IShape _redCircle = null;
            IShape _doubleArea = null;
            IShape _boldRectangle = null;
            IShape _boldCircle = null;
            IShape _doubleSize = null;

            Console.WriteLine("Do you wish to create a Circle or Rectangle");
            Console.WriteLine("Type 'C' for Circle and 'R' for Rectangle ");
            _string = Console.ReadLine();
           
            ///WHICH shape
            do
            {
                if (_string == "R")
                {
                    _shapeType = 1;
                }
                else if (_string == "C")
                {
                    _shapeType = 2;
                }
                else
                {
                    Console.WriteLine("Please choose a real pattern");
                    _string = Console.ReadLine();
                }
            } while (_string != "R" && _string != "C");

            ///WISH RED BORDER OR NOT
            Console.WriteLine("");
            Console.WriteLine("Do you wish to add a red border to your shape");
            Console.WriteLine("Press 'Y' for yes or 'N' for no");
            _string = Console.ReadLine();
            if (_string == "Y" && _shapeType == 1)
            {
                _redRectangle = new RedShapeDecorator(_rectangle);
                _colorAdded= true;
                _redRectangle.draw();
                Console.WriteLine("Default area is: {0}", _redRectangle.CalcArea());
            }
            else if (_string == "Y" && _shapeType == 2)
            {
                _redCircle = new RedShapeDecorator(_circle);
                _colorAdded= true;
                _redCircle.draw();
                Console.WriteLine("Default area is: {0}", _redCircle.CalcArea());
            }
            else
            {
                Console.WriteLine("No red border added");
                if (_shapeType == 1)
                {
                    _rectangle.draw();
                    Console.WriteLine("Default area is: {0}", _rectangle.CalcArea());
                    _colorAdded = false;
                }
                else
                {
                    _circle.draw();
                    Console.WriteLine("Default area is: {0}", _circle.CalcArea());
                    _colorAdded = false;
                }
            }


            //WISH BOLD LINES OR NOT 

            Console.WriteLine("Do you wish to make lines bold");
            Console.WriteLine("Press 'Y' for yes or 'N' for no");
            _string = Console.ReadLine();
            if (_string == "Y" && _shapeType == 1 && _colorAdded == true)
            {
                _boldRectangle = new BoldStyleDecorator(_redRectangle);
                _boldRectangle.draw();
                _bold = true;
                Console.WriteLine("Area with bold style: {0}", _boldRectangle.CalcArea());
                
            }
            else if (_string == "Y" && _shapeType == 2 && _colorAdded == true)
            {
                _boldCircle = new BoldStyleDecorator(_redCircle);
                _boldCircle.draw();
                _bold = true;
                Console.WriteLine("Area with bold style: {0}", _boldCircle.CalcArea());
            }
            else if (_string == "Y" && _shapeType == 1 && _colorAdded == false)
            {
                _boldRectangle = new BoldStyleDecorator(_rectangle);
                _boldRectangle.draw();
                Console.WriteLine("Area with bold style: {0}", _boldRectangle.CalcArea());
                _bold = true;

            }
            else if (_string == "Y" && _shapeType == 2 && _colorAdded == false)
            {
                _boldCircle = new BoldStyleDecorator(_circle);
                _boldCircle.draw();
                Console.WriteLine("Area with bold style: {0}", _boldCircle.CalcArea());
                _bold = true;
            }
            else
            {
                _bold = false;
                Console.WriteLine("No bold style added");
            }

            ///increase are by two
            /// 
            Console.WriteLine("");
            Console.WriteLine("Do you wish to double the size Y/N");
            _string = Console.ReadLine();
            if (_string == "Y")
            {
                if (_shapeType == 1 && _bold == true )
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    _doubleSize = new DoubleSizeDecorator(_boldRectangle);
                    Console.WriteLine("Area with bold style: {0}", _doubleSize.CalcArea());
                }
                else if (_shapeType == 2 && _bold == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    _doubleSize = new DoubleSizeDecorator(_boldCircle);
                    Console.WriteLine("Area with bold style: {0}", _doubleSize.CalcArea());
                }
                else if (_shapeType == 1 && _colorAdded == false && _bold == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    _doubleSize = new DoubleSizeDecorator(_rectangle);
                    Console.WriteLine("Area with bold style: {0}", _doubleSize.CalcArea());
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    _doubleSize = new DoubleSizeDecorator(_circle);
                    Console.WriteLine("Area with bold style: {0}", _doubleSize.CalcArea());
                }
            }
            else
                Console.WriteLine("Didn't increase size by two");
            

        }
    }
}
