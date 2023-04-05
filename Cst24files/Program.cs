using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Reflection.Metadata;

/*
string readText = File.ReadAllText("filename1.txt");
Console.WriteLine(readText);
File.WriteAllText("filename2.txt", readText);
Console.ReadKey();


try
{
    using (StreamReader sr1 = new StreamReader("filename1.txt"))
    {
        string line;
        while ((line = sr1.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
catch { Console.WriteLine("OOPS"); }

using (StreamWriter sw = new StreamWriter("RandomNumbers.txt"))
{
    for (int i = 0; i < 10; i++)
    {
        sw.WriteLine(Random.Shared.Next());
    }
}

Encoding unicode = Encoding.Unicode;
using (Stream stream = new FileStream("file.txt", FileMode.Create))
{
    using (StreamWriter sw = new StreamWriter(stream, unicode))
    {
        sw.WriteLine(Random.Shared.Next());
    }
}

*/
string fileNameWithPath_ = "filename1.txt";
System.IO.FileStream fileStream = new System.IO.FileStream(fileNameWithPath_, System.IO.FileMode.Open,
System.IO.FileAccess.Read);
System.IO.BinaryReader binReader = new System.IO.BinaryReader(fileStream, Encoding.ASCII);
byte[] data = binReader.ReadBytes((int)fileStream.Length);
for (int i = 0; i < data.Length; i++)
{
    Console.Write(String.Format("{0:x2} ", data[i]));
}
binReader.Close();
fileStream.Close();