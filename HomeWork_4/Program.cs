// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.Write("input your first number: ");
int num_1 =Convert.ToInt32(Console.ReadLine());

Console.Write("input your second number: ");
int num_2 =Convert.ToInt32(Console.ReadLine());

Console.Write("input your third number: ");
int num_3 =Convert.ToInt32(Console.ReadLine());

int max = num_1;
if (num_1 > max) max = num_1;
if (num_2 > max) max = num_2;
if (num_3 > max) max = num_3;

Console.Write($"max = {max}");