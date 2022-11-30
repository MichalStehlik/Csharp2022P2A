using Cst09abstraction;

Human alois = new Human { Firstname = "Alois", Lastname = "Avatar" };
Human boris = new Human { Firstname = "Boris", Lastname = "Bohatý" };
Animal devil = new Animal { Name = "Debil" };
// Entity ghost = new Entity { Name = "sdfhjfsdh" };

Entity[] entities = new Entity[] { alois, boris, devil };
foreach (var e in entities)
{
    Console.WriteLine(e.Name);
}