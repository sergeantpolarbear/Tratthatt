/*if (6 > 3)
{
    Console.WriteLine("Hello, World");
}

string yes = Console.ReadLine();
if (yes == "kalleanka")
{
    Console.WriteLine("Welcome");
}

string username = Console.ReadLine();
string password = Console.ReadLine();
if (username == "kalleanka" && password == "12345")
{
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine("Wrong usernameor password");
}

for (int i = 0; i < 32; i++)
{
    Console.WriteLine("Hello, World");
}

while (Console.ReadLine() != "12345")

int i = 0;
while (i < 5)
{
    string tratt = Console.ReadLine();
    int.TryParse(tratt, out int m);
    if (m > 5)
    {
        Console.WriteLine("Bigger than 5!");
    }
    i++;
}
*/
bool mmm = true;
int mm = 0;
while (mmm == true)
{
    string m = Console.ReadLine();
    int.TryParse(m, out mm);

    if (mm != 0 || m == "0")
    {
        mmm = false;
    }
}