class Employee
{
    //properties in camelCase
    internal int id;
    internal string? fullName;
    internal string? address;
    internal string? email;
    internal string? contact;
    internal decimal salary=0;
    internal bool isMale;
    internal byte role;
    internal DateTime createdDate;


    // methods || behaviors in Pascal case
    internal void GetInfo()
    {
        string gender = (isMale == true?"Male":isMale==false?"Female":"Others");
        string empRole = (role==0?"Manager":"Employee");
        System.Console.WriteLine($"Name : {fullName} \nAddress : {address} \nEmail : {email}\nContact : {contact}\nSalary : {salary} \nGender : {gender} \nRole : {empRole} \nCreated Date : {createdDate}");

    }

    internal int GetId()
    {
        // return this.Role;
        return id;
    }




}