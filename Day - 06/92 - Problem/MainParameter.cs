//namespace MainParameterProblem
//{
//    class MainParameter
//    {
//        public static void Main(string[] args)
//        {
//            _ = int.TryParse(args[0], out int nNum1);
//            char cOperator = Convert.ToChar(args[1]);
//            _ = int.TryParse(args[2], out int nNum2);

//            switch (cOperator)
//            {
//                case '+':
//                    Console.WriteLine(nNum1 + nNum2);
//                    break;

//                case '-':
//                    Console.WriteLine(nNum1 - nNum2);
//                    break;

//                case '*':
//                case 'X':
//                    Console.WriteLine(nNum1 * nNum2);
//                    break;

//                case '/':
//                    Console.WriteLine(nNum1 / nNum2);
//                    break;

//                default:
//                    Console.WriteLine("Invalid Operator");
//                    break;

//            }
//        }
//    }
//}
