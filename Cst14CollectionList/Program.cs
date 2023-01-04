using Cst14CollectionList;
using System.Collections;

ArrayList stupidList = new ArrayList();
stupidList.Add(4);
stupidList.Add("Ahoj");
stupidList.Add(new Student { Firstname = "Adam"});
stupidList.Add(new Student { Firstname = "Bořivoj" });
stupidList.Add(new Student { Firstname = "Cyril" });
Console.WriteLine(stupidList[0]);
foreach (var x in stupidList)
{
    Console.WriteLine(x);
}
foreach (var x in stupidList)
{
    if (x is Student)
    {
        Console.WriteLine((x as Student).Firstname);
    }  
}

Console.WriteLine("----");
List<Student> students = new List<Student>();
students.Add(new Student { Firstname = "Adam" });
students.Add(new Student { Firstname = "Bořivoj" });
students.Add(new Student { Firstname = "Cyril" });
foreach(Student x in students)
{
    Console.WriteLine(x.Firstname);
}
Console.WriteLine(students[0].Firstname);
// Console.WriteLine(students[100].Firstname); // exception
students[1] = new Student { Firstname = "Boris"};
students.RemoveAt(2);
Console.WriteLine(students.Count);

Console.WriteLine("----");
Dictionary<string, string> slovnicek = new Dictionary<string, string>();
slovnicek.Add("pes","dog");
slovnicek.Add("kocka","cat");
slovnicek.Add("myš","mouse");
Console.WriteLine(slovnicek.Count);
Console.WriteLine(slovnicek["pes"]);
// Console.WriteLine(slovnicek["velbloud"]); // exception
slovnicek.Remove("myš");