using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ogrenme
{
    class Lciz
    {
        private int Lyukseklik;
        private int Lgenislik;
        public int X;
        public int Y;

        public Lciz ()
        {
            Lyukseklik = 9;
            Lgenislik = 7;
            X = 40;
            Y = 10;
        }
        public Lciz(int gen, int yuk)
        {
            Lyukseklik = yuk;
            Lgenislik = gen;
        }
        public void goster()
        {
            if (X < 0 || X > 112 || Y < 0 || Y>29)
            {
                X = 10;
                Y = 7;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                for (int i = 0; i <= Lyukseklik; i++)
                {
                    Console.SetCursorPosition(X, Y + i);
                    Console.WriteLine(" ");
                    int z = Y + i;

                    if (i == Lyukseklik)
                    {
                        for (int a = 0; a <= Lgenislik; a++)
                        {
                            Console.SetCursorPosition(X + a, z);
                            Console.Write(" ");
                        }
                    }
                }
                Console.ResetColor();
            }
        }
    }
}

