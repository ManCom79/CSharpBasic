namespace GeometryLibrary
{
    public class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int[] Position { get; set; }

        public virtual string GetArea()
        {
            return "No special implementation for area.";
        }

        public virtual string GetPerimeter()
        {
            return "No special implementation for perimeter.";
        }
    }
}
