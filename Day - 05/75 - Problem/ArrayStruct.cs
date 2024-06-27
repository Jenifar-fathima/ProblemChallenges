namespace ArrayStructProblem
{
    struct CarDetails
    {
        public string CarName;
        public int CarYear;
    }

    class ArrayStruct
    {
        public static void Solution()
        {
            int nRange = 3; 
            CarDetails[] lstCarArray = new CarDetails[nRange];

            for (int i = 0; i < nRange; i++)
            {
                Console.Write($"Enter model for car {i + 1}: ");
                string? carName = Console.ReadLine();

                Console.Write($"Enter year of production for car {i + 1}: ");
                _ = int.TryParse(Console.ReadLine(), out int carYear);

                lstCarArray[i] = new CarDetails
                {
                    CarName = carName,
                    CarYear = carYear
                };
            }

            for (int i = 0; i < nRange; i++)
            {
                for (int j = i + 1; j < nRange; j++)
                {
                    if (lstCarArray[i].CarYear > lstCarArray[j].CarYear)
                    {
                        int tempYear = lstCarArray[i].CarYear;
                        lstCarArray[i].CarYear = lstCarArray[j].CarYear;
                        lstCarArray[j].CarYear = tempYear;

                        string tempName = lstCarArray[i].CarName;
                        lstCarArray[i].CarName = lstCarArray[j].CarName;
                        lstCarArray[j].CarName = tempName;
                    }
                }
            }

            foreach (CarDetails car in lstCarArray)
            {
                Console.WriteLine($"Model: {car.CarName}, Year of production: {car.CarYear}");
            }
        }
    }
}