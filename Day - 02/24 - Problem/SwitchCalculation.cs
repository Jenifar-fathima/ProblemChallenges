namespace SwitchCalculationProblem
{
    class SwitchCalculation
    {
        public static void Solution()
        {
            Console.Write("Enter the operand 1 :");
            int nOperand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operator :");
            string? strOperator = Console.ReadLine();
            Console.Write("Enter the operand 2 :");
            int nOperand2 = Convert.ToInt32(Console.ReadLine());
            switch (strOperator)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", nOperand1, strOperator, nOperand2, nOperand1 + nOperand2);
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", nOperand1, strOperator, nOperand2, nOperand1 - nOperand2);
                    break;
                case "*":
                case "X":
                    Console.WriteLine("{0} {1} {2} = {3}", nOperand1, strOperator, nOperand2, nOperand1 * nOperand2);
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", nOperand1, strOperator, nOperand2, nOperand1 / nOperand2);
                    break;
                case "%":
                case "mod":
                    Console.WriteLine("{0} {1} {2} = {3}", nOperand1, strOperator, nOperand2, nOperand1 % nOperand2);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}
