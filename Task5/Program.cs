// Напишите программу вычисления модуля числа.

string s_a = Console.ReadLine();
int a = int.Parse(s_a);
int x;
if (a < 0)
{
    x = -a;
    Console.WriteLine(x);
}
else
{
    x = a;
    Console.WriteLine(x);
}