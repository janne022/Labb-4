using OOP;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intialise a new circle object. Call methods for getting Area, Circumfrence and Volume
            Circle circle = new Circle(10);
            Console.WriteLine(circle.GetArea());
            Console.WriteLine(circle.GetCircumference());
            Console.WriteLine(circle.GetVolume());

            // Intialise a new triangle object. Call methods for getting Area
            Triangle triangle = new Triangle(10,5);
            Console.WriteLine(triangle.GetArea());
            Console.ReadLine();
        }
    }
}