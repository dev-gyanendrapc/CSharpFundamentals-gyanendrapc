using static System.Console;
using static System.Convert;

class Solutions
{
    public void EvenOdd()
    {
        WriteLine("Enter your number.");
        int num = ToInt32(ReadLine());
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
        WriteLine("Enter your p.");
        var p = ToDecimal(ReadLine());
        WriteLine("Enter your t.");
        var t = ToDecimal(ReadLine());
        WriteLine("Enter your r.");
        var r = ToDecimal(ReadLine());
        var si= ((p*t*r)/100);
        if (si > p)
        {
            WriteLine("surplus occured");
        }
        else
        {
            WriteLine("surplus not occured");
        }
    }
}