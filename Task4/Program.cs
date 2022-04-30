// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

string s_N = Console.ReadLine();
int N = int.Parse(s_N);
int x = 1;

while (x <= N)
{
    if ((x % 2) == 0)
    {
        Console.Write($"{x} ");
    }
    x++;
}




