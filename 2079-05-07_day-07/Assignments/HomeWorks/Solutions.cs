class Solutions
{
    /*
    PROGRAM TO PRINT ALL ODD NUMBERS RANGE FROM 1 TO 1000
    */
    internal void PrintOdd()
    {
        for (int i = 1, j = 1; j <= 500; i = i + 2, j++)
        {
            Console.WriteLine(
                format: "({0}) {1} is odd",
                arg0: j,
                arg1: i
            );
        }
    }
    /*
    PROGRAM TO PRINT ALL EVEN NUMBERS RANGE FROM 1 TO 1000
    */
    internal void PrintEven()
    {
        for (int i = 2, j = 1; j <= 500; i = i + 2, j++)
        {
            Console.WriteLine(
                format: "({0}) {1} is even",
                arg0: j,
                arg1: i
            );
        }
    }

    /*
    PROGRAM TO PRINT MULTIPLICATION TABLE OF GIVEN NUMBER
    */

    public void MulTable()
    {
        System.Console.WriteLine("Enter Your Number");
        var x = Convert.ToDecimal(Console.ReadLine());
        int i = 0;
        while (i < 10)
        {
            i++;
            System.Console.WriteLine(
                format: "{0} X {1} = {2}",
                arg0: x,
                arg1: i,
                arg2: (x * i)
            );
        }
    }
}