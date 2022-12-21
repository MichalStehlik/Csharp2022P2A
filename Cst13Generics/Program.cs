using Cst13Generics;

ValueStorage<int> vs = new ValueStorage<int>(10);
vs.Increase(8);
vs.Add<int>(7);
Console.WriteLine(vs.Value);