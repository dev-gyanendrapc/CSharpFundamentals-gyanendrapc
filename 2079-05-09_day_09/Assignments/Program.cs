using static System.Console;

UserMethods um = new();

WriteLine("Getting Short Detail Of User");
WriteLine(um.GetUser("Gyanendra Chaudhary", "9864374699"));

WriteLine("\nGetting Users Created Date");
WriteLine(um.GetCreatedDateTime());

WriteLine("\nGetting Users Full Details");
WriteLine(um.GetUser(fName: "Gyanendra Chaudhary", contact: "9864374699", address: "Kirtiput", salary: 0.00m));
