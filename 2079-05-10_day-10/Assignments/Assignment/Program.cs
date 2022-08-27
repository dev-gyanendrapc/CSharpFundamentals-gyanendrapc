ClassA a = new();
ClassB b = new();
DateTime dob =new DateTime(1997,02,05);
var (year, month, day)=a.GetAge(dob);
System.Console.WriteLine($"You Are : {year} Years, {month} Months And {day} Days Old.");

// taking new line
System.Console.WriteLine();

double[] arr = {10,30,5,9,55,3};
var (mean,median)=a.FindMeanMedian(arr);
System.Console.WriteLine($"Mean : {mean:N4} \nMedian : {median}");

//taking new line
System.Console.WriteLine();

int[] x = {1,10, 90, 3};
int[] y = {50,10, 90, 30};
var (asc,desc)=a.FindMeanMedian(x,y);
System.Console.WriteLine("Ascending Order :");
foreach(int res in asc ){
    System.Console.Write(res + ", ");
}
System.Console.WriteLine("\nDescending Order :");
foreach(int res in desc ){
    System.Console.Write(res + ", ");
}


// second problem
System.Console.WriteLine("\nTesting Visibility\n");


b.ProjectLvlVisibility();
b.GlobalLvlVisibility();
// not visible out side class
// b.ClassLvlVisibility();
