using static System.Console;
class TriangularPatterns
{
    internal void Pattern1()
    {
        for (int i = 1; i < 7; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Write("#");
            }
            WriteLine();
        }
    }

    internal void Pattern2()
    {
        for (int i = 2; i < 8; i++)
        {
            for (int j = 1; j < i; j++)
            {
                Write(j);
            }
            WriteLine();
        }
    }
    internal void Pattern3()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= (5 - i); j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k < i * 2; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    internal void Pattern4()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= (5 - i); j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k < i * 2; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
    }
}