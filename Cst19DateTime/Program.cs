/*
DateTime n = DateTime.Now;
Console.WriteLine(n.ToString());
Console.WriteLine(n.Year);
Console.WriteLine(n.Month);
Console.WriteLine(n.Day);
Console.WriteLine(n.Hour);
Console.WriteLine(n.Minute);
Console.WriteLine(n.Second);
Console.WriteLine(n.Millisecond);
Console.WriteLine(n.Ticks);
Console.WriteLine(n.DayOfWeek);
Console.WriteLine(n.DayOfYear);
DateTime m = DateTime.UtcNow;
Console.WriteLine(m.ToString());
DateTime o = new DateTime(2022,9,1,8,0,5);
Console.WriteLine(o.ToString());
TimeSpan ts = n - o;
Console.WriteLine(ts.ToString());
Console.WriteLine(ts.TotalMinutes);
Console.WriteLine(ts.TotalDays);
Console.WriteLine(o.AddDays(200));
Console.WriteLine(n + ts);
Console.WriteLine(n.ToShortDateString());
Console.WriteLine(n.ToString("G"));
*/
using System.Diagnostics;
/*
var start = Stopwatch.StartNew();
for(int i = 0; i < 10000; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine(start.ElapsedMilliseconds);
*/
var start2 = Stopwatch.StartNew();
await Task.Delay(1000);
Console.WriteLine(start2.ElapsedMilliseconds);