using Cst09abstraction;

Human alois = new Human { Firstname = "Alois", Lastname = "Avatar" };
Student boris = new Student { Firstname = "Boris", Lastname = "Bohatý" };
Animal devil = new Animal { Name = "Debil" };
AI x001 = new AI { Id = 1 };
// Entity ghost = new Entity { Name = "sdfhjfsdh" };

Entity[] entities = new Entity[] { alois, boris, devil };
foreach (var e in entities)
{
    Console.WriteLine(e.Name);
}

IGradeable[] members = new IGradeable[] { boris, x001 };
foreach (var e in members)
{
    e.SetGrade(1);
    Console.WriteLine(e.Grade);
    if (e is Student)
    {
        Console.WriteLine((e as Student).Name);
    }
}