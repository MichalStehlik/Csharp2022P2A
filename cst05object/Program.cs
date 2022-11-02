// See https://aka.ms/new-console-template for more information
using cst05object;

//Student adam = new Student();
Student adam = new Student("Adam","Kos",2,1.3);
Student fred = new Student();
//adam.firstname = "Adam";
//Console.WriteLine(adam.firstname);
//Console.WriteLine(adam.lastname);
//Console.WriteLine(adam);
//adam.firstname = "Adolf";
//Console.WriteLine(adam.firstname);
Console.WriteLine(adam.GetFirstname());
Console.WriteLine(adam.GetGrade());
adam.Advance();
adam.Advance();
adam.Advance();
adam.Advance();
adam.SetGrade(-12);
Console.WriteLine(adam.GetGrade());
Console.WriteLine(fred.GetFirstname());