namespace GeometryLibrary
{
    public class Rectangle : Shape
    {
        public int sideA { get; set; }
        public int sideB { get; set; }

        public override string GetArea()
        {
            int area = sideA * sideB;
            string result = $"{area.ToString()}";
            return result;
        }

        public override string GetPerimeter()
        {
            int perimeter = (2 * sideA) + (2 * sideB);
            string result = $"{perimeter.ToString()}";
            return result;
        }
    }
}
