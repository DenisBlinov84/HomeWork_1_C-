// Напишите программу, которая на вход принимает значение, а
// на выходе показывает обратное значение.
// 1 -> 1
// 2 -> 0.5
// 0.25 -> 4

string s_n_1 = Console.ReadLine();
double n_1 = double.Parse(s_n_1);
double i;

i = 1 / n_1;
Console.WriteLine(i);

