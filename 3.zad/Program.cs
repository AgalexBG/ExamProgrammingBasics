using System;

namespace _3.zad
{
    class Program
    {
        static void Main()
        {
            string fruit = Console.ReadLine();

            string size = Console.ReadLine();

            double orderedDrinks = double.Parse(Console.ReadLine());

            double price = 0;
            double allPrice = 0;



            switch (fruit)
            {
                case "Watermelon":
                    if (size == "small")
                    {
                        price = 2 * 56;
                        allPrice = price * orderedDrinks;
                    }
                    else
                    {
                        price = 5 * 28.70;
                        allPrice = price * orderedDrinks;
                    }
                    break;
                case "Mango":
                    if (size == "small")
                    {
                        price = 2 * 36.66;
                        allPrice = price * orderedDrinks;
                    }
                    else
                    {
                        price = 5 * 19.60;
                        allPrice = price * orderedDrinks;
                    }
                    break;
                case "Pineapple":
                    if (size == "small")
                    {
                        price = 2 * 42.10;
                        allPrice = price * orderedDrinks;
                    }
                    else
                    {
                        price = 5 * 24.80;
                        allPrice = price * orderedDrinks;
                    }
                    break;
                case "Raspberry":
                    if (size == "small")
                    {
                        price = 2 * 20;
                        allPrice = price * orderedDrinks;
                    }
                    else
                    {
                        price = 5 * 15.20;
                        allPrice = price * orderedDrinks;
                    }
                    break;

                default:
                    break;
            }
            if (allPrice > 1000)
            {
                allPrice -= allPrice * 0.50;
            }
            else if (allPrice >= 400)
            {
                allPrice -= allPrice * 0.15;
            }

            Console.WriteLine("{0:f2} lv.",allPrice);
        }
    }
}
