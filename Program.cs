//     Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
string s_num1 = Console.ReadLine();
int num1 = Convert.ToInt32(s_num1);
Console.Write("Введите второе число: "); 
string s_num2 = Console.ReadLine();
int num2 = Convert.ToInt32(s_num2);
Console.Write("Введите третье число: "); 
string s_num3 = Console.ReadLine();
int num3 = Convert.ToInt32(s_num3);

int max = num1;
if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.WriteLine(max);