// Return something and take some arguments

// double Add(double x, double y)
// {
//     return x + y;
// }
double Add(byte x, int y, float z)
{
    return x + y + z;
}

var sum = Add(20, 10, 10.5f);
System.Console.WriteLine(sum);