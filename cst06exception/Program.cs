using cst06exception;

ErrorMaker em = new ErrorMaker(1);
int x = 0;
em.AddNumber(-4,out x);
Console.WriteLine(em.GetValue());
var res = em.AddNumber2(-4);
if (res.Success) Console.WriteLine(em.GetValue());
//
try
{
    Console.WriteLine(em.AddNumber3(-4));
    Console.WriteLine(em.GetValue());
}
catch (ArgumentOutOfRangeException ex) {
    Console.WriteLine("Nesmyslná hodnota:" + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Obecná chyba: " + ex.Message);
}