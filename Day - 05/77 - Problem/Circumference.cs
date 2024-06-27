namespace CircumferenceProblem
{
    class Circumference
    {
        public static void Solution()
        {
            double xPoint, yPoint;
            double nRadius;

            for (int i = 0; i < 360; i+=1)
            {
                nRadius = i * Math.PI / 180.0;

                xPoint = 35 + 8 * Math.Cos(nRadius);
                yPoint = 10 + 8 * Math.Sin(nRadius);

                Console.SetCursorPosition((int)xPoint, (int)yPoint);
                Console.Write("X");
            }

            Console.SetCursorPosition(1, 20);
        }
    }
}
