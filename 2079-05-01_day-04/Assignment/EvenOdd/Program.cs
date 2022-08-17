using static System.Console;
using static System.Convert;


Write("Enter your number : ");
var num = ToInt32(ReadLine());


if(num % 2 == 0){
    WriteLine($"{num} is even.");
}else{
    WriteLine($"{num} is odd.");
}