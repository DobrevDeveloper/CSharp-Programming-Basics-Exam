using System;

namespace GiftsFromSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for(int count = m; count >= n; count--)
            {
                if(count % 2 == 0 && count % 3 == 0)
                {
                    if(count == s)
                    {
                        break;
                    }

                    else
                    {
                        Console.Write(count + " ");
                    }
                }

            }
        }
    }
}
