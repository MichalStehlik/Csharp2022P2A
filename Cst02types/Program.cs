int a = 12;
var b = "Ahoj";

// mensi do vetsiho - implicitní přetypování
float e = 11.1f;
double f = e;

// vetsi do mensiho - explicitní přetypování
double c = 12.4;
float d = (float)c;

// konverze
string g = "12";
//int h = (int)g;

int i;
bool ok = Int32.TryParse(g, out i);
int k = Int32.Parse(g);
int l = Convert.ToInt32(g);

Console.WriteLine(sizeof(int));