namespace ShapeClassDiagramProblem
{
    class ShapeClassDiagram
    {
        public static void Solution()
        {

        }
    }
    public class Shape
    {
        private Location c;
        public string ToString()
        {
            return string.Empty;
        }
        public double Area()
        {
            return 0.00;
        }
        public double Perimeter()
        {
            return 0.00;
        }
    }
    public class Location
    {
        private double x, y;
    }
    public class Circle : Shape
    {
        private double radius;
    }
    public class Rectange : Shape
    {
        private double side1, side2;
    }
}
