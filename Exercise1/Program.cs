// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

string s = Console.ReadLine();

bool isInt = int.TryParse(s, out int result);

//int y = int.Parse(s);
if (isInt)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("no number");
}


int x = 10, y = 20;

(x,y)=(y,x);
// int tmp = x;
//
// x = y;
// y = tmp;

Console.WriteLine($"{x} {y}");