using static System.Console;

// getting user address from user
Write("Enter Your Address : ");
var address = ReadLine();
// converting to user address to UpperCase
address = address.ToUpper();
// showing on console
WriteLine($"You are from {address}");

