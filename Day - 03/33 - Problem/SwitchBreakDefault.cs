namespace SwitchBreakDefaultProblem
{
    class SwitchBreakDefault
    {
        public static void Solution()
        {
            Console.Write("Enter the grade Number :");
            bool IsNum = int.TryParse(Console.ReadLine(), out int nNum);
            if (IsNum)
            {
                switch (nNum)
                {
                    case 10:
                        Console.WriteLine("A+");
                        break;
                    case 9:
                        Console.WriteLine("A");
                        break;
                    case 8:
                    case 7:
                        Console.WriteLine("B");
                        break;
                    case 6:
                        Console.WriteLine("C");
                        break;
                    case 5:
                        Console.WriteLine("E");
                        break;
                    default:
                        Console.WriteLine("F");
                        break;
                }
            }
        }
    }
}
