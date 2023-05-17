using HtmlAgilityPack;
using System.Net;

string downloadFolder = "downloads"; // sem budeme stahovat
Uri myUri = new Uri("https://pslib.cz/o-skole/galerie/140-vyroci-zalozeni-skoly"); // stránka
string host = myUri.Host;
Console.WriteLine(host);
string scheme = myUri.Scheme;
Console.WriteLine(scheme);
string leftPart = myUri.GetLeftPart(UriPartial.Authority);
Console.WriteLine(leftPart); // adresa serveru a schéma

// nalezení všech odkazů na obrázky
var web = new HtmlWeb();
var doc = web.Load(myUri.ToString());
var linkedPages = doc.DocumentNode.Descendants("a")
    .Select(a => a.GetAttributeValue("href", null))
    .Where(u => !String.IsNullOrEmpty(u) && (u.ToUpper().EndsWith(".JPG")));

// založení složky
if (!Directory.Exists(downloadFolder))
{
    Directory.CreateDirectory(downloadFolder);
}

// kontrola, zda už soubor nemáme stažený
foreach (var linkedPage in linkedPages)
{
    Console.WriteLine(linkedPage);
    var fullUri = leftPart + linkedPage;
    string filename = Path.GetFileName(new Uri(fullUri).AbsolutePath);
    Console.WriteLine(filename);
    string downloadPath = Path.Combine(downloadFolder, filename);
    Console.WriteLine(downloadPath);
    if (File.Exists(downloadPath))
    {
        try
        {
            File.Delete(downloadPath);
        }
        catch { Console.WriteLine("Smazání souboru se nepodařilo."); }
    }

    // samotné stažení souboru
    using (var client = new WebClient())
    {
        client.DownloadFile(fullUri, downloadPath);
    }
}