namespace DoubleValueProblem
{
    class DoubleValue
    {
        public static void Solution()
        {
            Console.Write("Width :");
            double fWidth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height :");
            double fHeight = Convert.ToDouble(Console.ReadLine());

            double fArea = fWidth * fHeight;
            double fPerimeter = 2*(fWidth + fHeight);
            double fDiagonal = (double)Math.Sqrt(Math.Pow(fWidth, 2) + Math.Pow(fHeight, 2));

            Console.WriteLine("Perimeter :{0}\nArea :{1}\nDiagonal :{2}", fPerimeter, fArea, fDiagonal);
        }
    }
}