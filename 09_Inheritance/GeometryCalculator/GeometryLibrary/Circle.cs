namespace GeometryLibrary
{
    public class Circle : Shape
    {
        public int Radius {  get; set; }

        public override string GetArea()
        {
            double area = Math.Pow(Radius, 2) * 3.14;
            string result = area.ToString();
            return result;
        }

        public override string GetPerimeter()
        {
            double perimeter = 2 * Radius * 3.14;
            string result = perimeter.ToString();
            return result;
        }
    }
}
