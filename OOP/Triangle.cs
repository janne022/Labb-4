using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Triangle
    {
        // Declare variables for width, height
        private double _width;
        private double _height;
        // Create a new constructor for getting values
        public Triangle(double width, double height)
        {
            _width = width;
            _height = height;
        }
        // Get area from triangle
        public double GetArea()
        {
            return (_width * _height) / 2;
        }
    }
}
