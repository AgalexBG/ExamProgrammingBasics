using System;

namespace _2.zad
{
    class Program
    {
        static void Main()
        {
            double record = double.Parse(Console.ReadLine());
            double lenghtInMeters = double.Parse(Console.ReadLine());
            double OneMeterSwim = double.Parse(Console.ReadLine());
 
            double Swimming = lenghtInMeters * OneMeterSwim;

            double HisRecord = (Math.Floor(lenghtInMeters / 15) * 12.5);

            double fullTime = Swimming + HisRecord;
            double fail = fullTime - record;

            if (fullTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {fullTime:f2} seconds.");
            }
            if(record <= fullTime)
            {
                Console.WriteLine($"No, he failed! He was {fail:f2} seconds slower.");
            }
        
        }
    }
}
