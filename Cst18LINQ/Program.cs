using Cst18LINQ;
using System.Reflection.Metadata.Ecma335;

List<Student> students = new List<Student>
{
    new Student { FirstName = "Arnold", Classroom = "A", AverageGrade = 1.1},
    new Student { FirstName = "Bořivoj", Classroom = "B", AverageGrade = 3.5},
    new Student { FirstName = "Ctirad", Classroom = "A", AverageGrade = 1.5},
    new Student { FirstName = "Dalimil", Classroom = "A", AverageGrade = 2.5},
    new Student { FirstName = "Evžen", Classroom = "B", AverageGrade = 3.0},
    new Student { FirstName = "Fiona", Classroom = "A", AverageGrade = 1.6},
    new Student { FirstName = "Gertrude", Classroom = "B", AverageGrade = 3.8},
    new Student { FirstName = "Hilde", Classroom = "A", AverageGrade = 4.8},
    new Student { FirstName = "Igor", Classroom = "B", AverageGrade = 2.2},
    new Student { FirstName = "Johann", Classroom = "B", AverageGrade = 3.2},
    new Student { FirstName = "Knut", Classroom = "A", AverageGrade = 2.1},
    new Student { FirstName = "Libor", Classroom = "B", AverageGrade = 3.1},
    new Student { FirstName = "Magnus", Classroom = "A", AverageGrade = 1.1},
    new Student { FirstName = "Niobe", Classroom = "B", AverageGrade = 2.5},
    new Student { FirstName = "Otmar", Classroom = "A", AverageGrade = 1.1},
    new Student { FirstName = "Petra", Classroom = "B", AverageGrade = 1.6},
    new Student { FirstName = "Quido", Classroom = "A", AverageGrade = 2.5},
    new Student { FirstName = "Roland", Classroom = "A", AverageGrade = 1.8},
    new Student { FirstName = "Simon", Classroom = "B", AverageGrade = 2.1},
    new Student { FirstName = "Tadeáš", Classroom = "A", AverageGrade = 4.98},
    new Student { FirstName = "Uwe", Classroom = "B", AverageGrade = 1.1},
    new Student { FirstName = "Vanda", Classroom = "B", AverageGrade = 2.3},
    new Student { FirstName = "Wolfgang", Classroom = "A", AverageGrade = 1.1},
    new Student { FirstName = "Xénie", Classroom = "A", AverageGrade = 1.6},
    new Student { FirstName = "Yvette", Classroom = "A", AverageGrade = 1.7},
    new Student { FirstName = "Zoltán", Classroom = "B", AverageGrade = 4.1},
};
/*
foreach (var x in students.OrderBy(x => x.AverageGrade))
{
    Console.WriteLine(x);
}
*/
/*
foreach (var x in students.OrderByDescending(x => x.AverageGrade))
{
    Console.WriteLine(x);
}
*/
// Console.WriteLine(students.Average(x => x.AverageGrade));
/*
foreach (var x in students.Take(5))
{
    Console.WriteLine(x);
}
*/
/*
foreach (var x in students.OrderBy(x => x.AverageGrade).Take(5))
{
    Console.WriteLine(x);
}
*/
/*
foreach (var x in students.Where(x => x.Classroom == "A"))
{
    Console.WriteLine(x);
}
*/
/*
foreach (var x in students.Where(x => x.Classroom == "A").OrderBy(x =>x.AverageGrade))
{
    Console.WriteLine(x);
}
*/
/*
foreach (var x in students.Select(x => new { Name = x.FirstName, Class = x.Classroom }))
{
    Console.WriteLine(x);
}
*/
/*
foreach (var x in students.Select(x => {
    return new Student
    {
        FirstName = "Fred",
        Classroom = x.Classroom,
        AverageGrade = x.AverageGrade
    };
}))
{
    Console.WriteLine(x);
}
*/
/*
foreach (var x in students.GroupBy(x => x.Classroom))
{
    Console.WriteLine(x.Key + " " + x.Count());
}
*/
/*
foreach (var x in students.GroupBy(x => x.Classroom))
{
    Console.WriteLine("-- " + x.Key + " --");
    foreach (var y in x)
    {
        Console.WriteLine(y);
    }
}
*/
foreach (var x in students
    .GroupBy(x => x.Classroom)
    .Select(w => new StudentSummary { 
        Name = w.Key, 
        Count = w.Count(),
        Avg = w.Average(y => y.AverageGrade)
    })
    .OrderBy(x => x.Avg))
{
    Console.WriteLine(x);
}