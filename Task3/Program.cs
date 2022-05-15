// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

string s_n_1 = Console.ReadLine();
int n_1 = int.Parse(s_n_1);

if (n_1 % 2 == 0)
{
    Console.Write($"The number {n_1} is even ");
}
else
{
    Console.Write($"The number {n_1} is odd ");
}