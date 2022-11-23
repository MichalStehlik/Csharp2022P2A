using Cst08polymorphism;

Human tonda = new Human { Name = "Tonda" };
Console.WriteLine(tonda.Fullname());
Student merta = new Student { Name = "Merta", Grade = 2};
Console.WriteLine(merta.Fullname());

Human ivan = new Student { Name = "Ivan", Grade = 1 };
Console.WriteLine(ivan.Fullname());

Teacher michal = new Teacher { Name = "Michal", Shortname = "St" };


Console.WriteLine("---");
Human[] ucastnici = new Human[] { tonda, merta, ivan, michal };
foreach(var u in ucastnici)
{
    Console.WriteLine(u);
}