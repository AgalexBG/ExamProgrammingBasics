using System;


namespace Exam
{
    class Program
    {
        static void Main()
        {

            double cake = 45;
            double waffles = 5.80;
            double pancakes = 3.20;

            double days = double.Parse(Console.ReadLine());
            double cooker = double.Parse(Console.ReadLine());
            double cakeCount = double.Parse(Console.ReadLine());
            double wafflesCount = double.Parse(Console.ReadLine());
            double pancakesCount= double.Parse(Console.ReadLine());

            double moneyForOneDay = ((cake * cakeCount) + (waffles * wafflesCount) + (pancakes * pancakesCount)) * cooker;

            double moneyForAllCampain = moneyForOneDay * days;

            moneyForAllCampain -=  moneyForAllCampain/8;

            Console.WriteLine("{0:f2}",moneyForAllCampain);


        }
    }
}
