using static System.Console;
using static System.Convert;

class Solutions
{
    public void EvenOdd()
    {
        WriteLine("Program To Find Even Or Odd");
        var num = 10;
        if (num % 2 == 0)
        {
            WriteLine($"{num} is even");
        }
        else
        {
            WriteLine($"{num} is odd");
        }
    }
    public void SISurpluss()
    {
        WriteLine("Program To Find If Interest Is Greater Than Principle Amount:");
        WriteLine("Enter your p.");
        var p = ToDecimal(ReadLine());
        WriteLine("Enter your t.");
        var t = ToDecimal(ReadLine());
        WriteLine("Enter your r.");
        var r = ToDecimal(ReadLine());
        var si= ((p*t*r)/100);
        if (si > p)
        {
            WriteLine($"interest {si} surpasses principal amount {p}.");
        }
        else
        {
            WriteLine($"interest {si} not surpasses principal amount {p}.");
        }
    }
}