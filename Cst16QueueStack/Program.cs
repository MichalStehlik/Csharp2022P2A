Queue<int> fronta = new Queue<int>();
fronta.Enqueue(1);
fronta.Enqueue(2);
fronta.Enqueue(3);
fronta.Enqueue(4);
fronta.Enqueue(5);
fronta.Enqueue(6);
Console.WriteLine(fronta.Dequeue());
Console.WriteLine("----");
Console.WriteLine(fronta.Peek());
Console.WriteLine(fronta.Dequeue());
Console.WriteLine(fronta.Count);
Console.WriteLine("----");
foreach(var x in fronta)
{
    Console.WriteLine(x);
}
foreach (var x in fronta)
{
    Console.WriteLine(x);
}
// fronta.Clear();
Console.WriteLine(fronta.Contains(4));
Console.WriteLine("-------------------------");
Stack<int> zasobnik = new Stack<int>();
zasobnik.Push(1);
zasobnik.Push(2);
zasobnik.Push(3);
zasobnik.Push(4);
zasobnik.Push(5);
zasobnik.Push(6);
Console.WriteLine(zasobnik.Pop());
Console.WriteLine(zasobnik.Peek());
foreach (var x in zasobnik)
{
    Console.WriteLine(x);
}
// zasobnik.Clear();
Console.WriteLine(zasobnik.Contains(4));