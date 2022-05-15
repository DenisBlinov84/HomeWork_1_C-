// Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.

string s_n_1 = Console.ReadLine();
string s_n_2 = Console.ReadLine();
string s_n_3 = Console.ReadLine();

int n_1 = int.Parse(s_n_1);
int n_2 = int.Parse(s_n_2);
int n_3 = int.Parse(s_n_3);

if (n_1 < n_2)
{
    n_1 = n_2;
}
if (n_1 < n_3)
{
    n_1 = n_3;
}
Console.Write($"The number {n_1} is the largest! ");
