namespace FloatValueProblem
{
    class FloatValue
    {
        public static void Solution()
        {
            Console.Write("Distance in meter :");
            float fDistanceInMeter = Convert.ToSingle(Console.ReadLine());
            Console.Write("Time in Hours :");
            float fHour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Time in Minutes :");
            float fMinute = Convert.ToSingle(Console.ReadLine());
            Console.Write("Time in Seconds :");
            float fSeconds = Convert.ToSingle(Console.ReadLine());

            float fSpeedInMeter = fDistanceInMeter / (fHour * 3600 + fMinute * 60 + fSeconds);  
            float fSpeedInKm = (fDistanceInMeter / 1000) / (fHour + fMinute / 60 + fSeconds / 3600); 
            float fSpeedInMile = (fDistanceInMeter/1609) / (fHour + fMinute / 60 + fSeconds / 3600); 

            Console.WriteLine("Speed In Meter :{0}\nSpeed In km :{1}\nSpeed In mile :{2}", fSpeedInMeter, fSpeedInKm, fSpeedInMile);
        }
    }
}
