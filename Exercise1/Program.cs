// See https://aka.ms/new-console-template for more information

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


int x = 10, y = 20;
// int tmp = x;
//
// x = y;
// y = tmp;

Console.WriteLine($"{x} {y}");