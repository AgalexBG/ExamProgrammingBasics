using System;


namespace _4.zad
{
    class Program
    {
        static void Main()
        {
            double partsOfTheProject = double.Parse(Console.ReadLine());
            double moneyForOnePoint = double.Parse(Console.ReadLine());

            double point = 0;
            double allpoints = 0;

            for (int i = 1; i <= partsOfTheProject; i++)
            {
                point = double.Parse(Console.ReadLine());
                if (i  % 2 == 0 )
                {
                    point = point * 2;
                }

                allpoints += point;
            }
            double price = allpoints * moneyForOnePoint;

            Console.WriteLine($"The project prize was {price:f2} lv.");
        }
    }
}
