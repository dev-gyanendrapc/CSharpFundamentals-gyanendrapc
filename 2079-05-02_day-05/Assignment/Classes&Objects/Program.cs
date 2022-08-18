class Program
{
    //entry point Main method
    public static void Main(String[] args)
    {
        // initializing employee
        var harry = new Employee()
        {
            id = 1,
            fullName = "Harry",
            address = "UK",
            email = "harry9@gmail.com",
            contact = "443214964",
            salary = 4500,
            isMale = true,
            role = 1,
            createdDate = DateTime.Now
        };
        //getting employee id
        System.Console.WriteLine($"Employee ID : {harry.GetId()}");
        System.Console.WriteLine("------------------------------------------------");
        // getting employee information
        System.Console.WriteLine("Employee Information : ");
        harry.GetInfo();
        System.Console.WriteLine("------------------------------------------------");
        //getting name directly coz it has internal access modifier
        System.Console.WriteLine($"Employee Name : {harry.fullName}");
    }
}