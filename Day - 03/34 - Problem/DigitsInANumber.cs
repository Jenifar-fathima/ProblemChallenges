namespace ProblemChallenges.Day___03._34___Problem
{
    class DigitsInANumber
    {
        public static void Solution()
        {
            bool IsTrue = int.TryParse(Console.ReadLine(), out int nValue);

            if (IsTrue)
            {
                int nDigits = 0;

                if (nValue < 0)
                {
                    Console.WriteLine("(Warning: it is a negative number)");
                    nValue = -nValue;
                }

                while (nValue > 0)
                {
                    nValue /= 10;
                    nDigits++;
                }

                if (nDigits == 0)
                {
                    nDigits = 1;
                }

                Console.WriteLine("{0} digits", nDigits);
            }
        }
    }
}
