// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

string first = Console.ReadLine();
string second = Console.ReadLine();

bool firstIsInt = int.TryParse(first, out int result1);
bool secondIsInt = int.TryParse(second, out int result2);

if (firstIsInt && secondIsInt)
{
    int sum = result1 + result2;
    Console.WriteLine($"Sum is {sum}");

    int subtract = result1 - result2;
    Console.WriteLine($"Subtract {subtract} sum is {sum}");

    Console.WriteLine("Subtract {0}, sum is {1}", subtract, sum);

    int multiply = result1 * result2;
}


string s = Console.ReadLine();

bool i = int.TryParse(s, out int x1);

if (i && x1 > 0)
{
    Console.WriteLine("number is positive");
}

int x = 10, y = 20;

int tmp = x; //tmp - 10
x = y; // x- 20 y - 20
y = tmp; // y- 10


Console.WriteLine($"{x} {y}");

double d = 123.65;
int x2 = (int)d;

Console.WriteLine(x2);