using System;


namespace _5.zad
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = n;
            int width = (4 * n) + 1;
            int height = (2 * n) + 1;

            Console.WriteLine($"{new string('#',width)}");
            int offset = 1;
            int spaces = 0;

            for (int i = 1; i <= n; i++)
            {
               
               
                    if (i == (n / 2)+1)
                    {
                        spaces = (offset - 3) / 2;
                        Console.WriteLine($"{new string('.', i)}{new string('#', (width - (2 * i) - offset) / 2)}{new string(' ', spaces)}(@){new string(' ', spaces)}{new string('#', (width - (2 * i) - offset) / 2)}{new string('.', i)}");
                        offset += 2;

                    }
                    else
                    {
                        Console.WriteLine($"{new string('.', i)}{new string('#', (width - (2 * i) - offset) / 2)}{new string(' ', offset)}{new string('#', (width - (2 * i) - offset) / 2)}{new string('.', i)}");
                        offset += 2;
                    }
                
                
            }
            m = m + 1;
            for (int j = 1; j <= n ; j++)
            {
                Console.WriteLine($"{new string('.',m)}{new string('#',width-(m*2))}{new string('.', m)}");
                m++;
                offset -= 2;
            }

        }
    }
}
