using System;
namespace MyApp
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please , enter the First number");
            int N1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please , enter the Second number ");
            int N2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = N1; i <= N2; i++)


                if (i % 2 == 0)
                {
                    if (i == 2)
                        Console.WriteLine("The number {0} is Prime ", i);
                    else
                        Console.WriteLine("The number {0} is notPrime ", i);

                }

                else
                {


                    if (i < 8 && (i % 3 == 0 || i % 5 == 0 || i % 7 == 0))
                    {
                        Console.WriteLine("The number {0} is Prime", i);

                        continue;
                    }

                    if (i > 8 && (i % 3 == 0 || i % 5 == 0 || i % 7 == 0))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("The number {0} is Prime ", i);
                    }


                }
        }
    }
}
