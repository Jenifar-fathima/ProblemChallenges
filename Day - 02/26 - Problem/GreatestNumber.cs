namespace GreatestNumberProblem
{
    class GreatestNumber
    {
        public static void Solution()
        {
            Console.Write("Enter the Value 1:");
            int nValue1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Value 2:");
            int nValue2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Value 3:");
            int nValue3 = Convert.ToInt32(Console.ReadLine());

            if (nValue1 > nValue2 && nValue1 > nValue3 && nValue1!= nValue2 && nValue1 != nValue3)
            {
                Console.WriteLine("{0} is the highest value",nValue1);
            }
            else if (nValue2 > nValue1 && nValue2 > nValue3 && nValue2 != nValue1 && nValue2 != nValue3)
            {
                Console.WriteLine("{0} is the highest value", nValue2);
            }
            else if (nValue3 > nValue1 && nValue3 > nValue2 && nValue3 != nValue2 && nValue3 != nValue1)
            {
                Console.WriteLine("{0} is the highest value", nValue3);
            }
            else
            {
                Console.WriteLine("Nothing is greater");
            }
        }
    }
}
