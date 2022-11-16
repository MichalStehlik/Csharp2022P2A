using cst07properties;

Knight alfons = new Knight("Alfons");
//alfons._name = "Eduard";
//Console.WriteLine(alfons.name);
//Console.WriteLine(alfons.GetName());
Console.WriteLine(alfons.Name);
alfons.Name = "Jiří";
Console.WriteLine(alfons.Name);
alfons.Name = "Medojed";
Console.WriteLine(alfons.Name);
alfons.GetHit(2);
Console.WriteLine(alfons.HP);
Knight kotlar = new Knight("Kotlar",100);
alfons.Attack(kotlar,5);