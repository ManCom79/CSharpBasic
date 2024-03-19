using GeometryLibrary;

namespace GeometryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle01 = new Rectangle();
            rectangle01.Name = "Rectangle_01";
            rectangle01.sideA = 3;
            rectangle01.sideB = 2;

            string rectangleArea = rectangle01.GetArea();
            string rectabglePerimeter = rectangle01.GetPerimeter();

            Console.WriteLine("*** Rectangle ***");
            Console.WriteLine($"The area of the {rectangle01.Name} is {rectangleArea}.");
            Console.WriteLine($"The perimeter of the {rectangle01.Name} is {rectabglePerimeter}.");
            Console.WriteLine("*****************");

            Circle circle01 = new Circle();
            circle01.Name = "Circle_01";
            circle01.Radius = 3;

            string circleArea = circle01.GetArea();
            string circlePerimeter = circle01.GetPerimeter();

            Console.WriteLine("*** Circle ***");
            Console.WriteLine($"The area of the {circle01.Name} is {circleArea}.");
            Console.WriteLine($"The circumference of the {circle01.Name} is {circlePerimeter}.");
            Console.WriteLine("*****************");

        }
    }
}
