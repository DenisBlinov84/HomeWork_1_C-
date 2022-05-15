// Напишите программу вычисления модуля числа.

string s_n_1 = Console.ReadLine();
int n_1 = int.Parse(s_n_1);
int i;
if (n_1 < 0)
{
    i = -n_1;
    Console.WriteLine(i);
}
else
{
    i = n_1;
    Console.WriteLine(i);
}