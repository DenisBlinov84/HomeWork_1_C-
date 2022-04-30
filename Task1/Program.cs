// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

string s_a = Console.ReadLine();
string s_b = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);

if(a>b){
    Console.WriteLine ("{0} наибольшее число" , a );
    Console.WriteLine ("{0} наименьшее число" , b );
}
else{
    Console.WriteLine ("{0} наибольшее число" , b );
    Console.WriteLine ("{0} наименьшее число" , a );
}