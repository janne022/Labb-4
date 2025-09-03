using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Circle
    {
        int _radius;
        public Circle(int radius)
        {
            _radius = radius;
        }
        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}