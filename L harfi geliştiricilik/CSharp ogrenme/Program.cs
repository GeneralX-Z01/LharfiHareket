using System;

namespace CSharp_ogrenme
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Lciz harf = new Lciz();
            while (true)
            {
                
                    ConsoleKeyInfo tus = Console.ReadKey();
                    if (tus.Key == ConsoleKey.A || tus.Key == ConsoleKey.LeftArrow)
                    {
                        harf.X = harf.X - 5;
                    }
                    if (tus.Key == ConsoleKey.D || tus.Key == ConsoleKey.RightArrow)
                    {
                        harf.X = harf.X + 5;
                    }
                    if (tus.Key == ConsoleKey.S || tus.Key == ConsoleKey.DownArrow)
                    {
                        harf.Y = harf.Y + 2;
                    }
                    if (tus.Key == ConsoleKey.W || tus.Key == ConsoleKey.UpArrow)
                    {
                        harf.Y = harf.Y - 2;
                    }
                    if (tus.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    Console.Clear();
                    harf.goster();
                
            
            }
            Console.ReadKey();
        }
    }
}
