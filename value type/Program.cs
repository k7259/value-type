// See https://aka.ms/new-console-template for more information
using value_type;

Console.WriteLine("Hello, World!");
int i = 10;// this value type variable.
Class1 cs = new Class1();
cs.Changedata(i);
Console.WriteLine(i);
Student mystudent= new Student();// reference type variable.
mystudent.i = 10;
cs.Changedata(mystudent);
Console.WriteLine(mystudent.i);
// is string are reference type or value type ?
// ans:=- string is a refernce type but behaviour is value type .
string str1 = "sanjay";
cs.Changedata(str1);
Console.WriteLine(str1);
