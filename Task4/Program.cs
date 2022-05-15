// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

string s_n_1 = Console.ReadLine();
int n_1 = int.Parse(s_n_1);
int i = 2;

while (i <= n_1)
{
    if ((i % 2) == 0)
    {
        Console.Write($"{i} ");
    }
    i += 2;
}




