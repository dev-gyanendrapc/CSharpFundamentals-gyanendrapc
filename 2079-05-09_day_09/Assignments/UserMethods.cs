class UserMethods
{
    /*
        CONDITION
        Method 1 must take 2 parameters and return string.
    */
    internal string GetUser(string fName, string contact)
    {
        string result = $"Name {fName} \nContact {contact}";
        return result;
    }
    
    /*
        CONDITION
        Method 2 take no parameters and return DateTime.
    */
    internal DateTime GetCreatedDateTime(){
        return DateTime.Now;
    }
    /*
    Method 3 is overload of method 1 and takes 4 arguments.
    */
    internal string GetUser(string fName, string contact, string address, decimal salary)
    {
        string result = $"Name : {fName} \nContact : {contact} \nAddress : {address} \nSalary : {salary}";
        return result;
    }
}