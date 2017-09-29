using System;


namespace zad._6
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool good = false;

            for (int a = 1; a <= 30; a++)
            {                
                for (int b = 1; b <=30; b++)
                {
                    for (int c = 1; c <= 30 ; c++)
                    {                    
                        if (a<b && b<c)
                        {
                            if (a+b+c == n)
                            {
                                good = true;
                                Console.WriteLine($"{a} + {b} + {c} = {n}");
                                
                            }                           
                        }
                        if (a>b && b>c)
                        {
                            if (a*b*c == n)
                            {
                                good = true;
                                Console.WriteLine($"{a} * {b} * {c} = {n}");
                                
                            }                           
                        }                      
                    }
                }
            }
            if (good == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}


