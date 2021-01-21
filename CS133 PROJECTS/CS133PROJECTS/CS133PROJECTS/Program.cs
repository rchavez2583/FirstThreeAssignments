using System;

namespace CS133PROJECTS
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] arr2d = new int[10, 10];



            for (int Y = 0; Y < 10; Y++)
            {
                for (int X = 0; X < 10; X++)
                {
                    arr2d[X, Y] = (X + 1) * (Y + 1);
                }


            }

            for (int Y = 0; Y < 10; Y++)
            {
                for (int X = 0; X < 10; X++)
                {
                    Console.Write(arr2d[X, Y] + " ");
                }

                Console.WriteLine("");

            }
        }
    }
}
