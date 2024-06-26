namespace PurchaseChangeProblem
{
    public class PurchaseChange
    {
        public static void Solution()
        {
            Console.Write("Enter the total amount given by the user :");
            bool bIsTotalAmount = int.TryParse(Console.ReadLine(),out int nTotalAmount);
            Console.Write("Enter the purchased amount :");
            bool bIsPurchasedAmount = int.TryParse(Console.ReadLine(), out int nPurchasedAmount);

            if( bIsTotalAmount && bIsPurchasedAmount)
            {
                int nChange = nTotalAmount - nPurchasedAmount;

                while (nChange >= 50)
                {
                    Console.Write("50 ");
                    nChange -= 50;
                }

                while (nChange >= 20)
                {
                    Console.Write("20 ");
                    nChange -= 20;
                }

                while (nChange >= 10)
                {
                    Console.Write("10 ");
                    nChange -= 10;
                }

                while (nChange >= 5)
                {
                    Console.Write("5 ");
                    nChange -= 5;
                }

                while (nChange >= 2)
                {
                    Console.Write("2 ");
                    nChange -= 2;
                }

                while (nChange >= 1)
                {
                    Console.Write("1 ");
                    nChange -= 1;
                }
            }
        }
    }
}
