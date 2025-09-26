using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Circle
    {
        // Declare variables such as radius via constructor
        private int _radius;
        public Circle(int radius)
        {
            _radius = radius;
        }
        // Get area
        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
        // Get circumference
        public double GetCircumference()
        {
            return 2 * Math.PI * _radius;
        }
        // Get volume
        public double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(_radius,3);
        }
    }
}