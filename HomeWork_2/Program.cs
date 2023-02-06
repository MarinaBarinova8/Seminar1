// Задача 2. Напишите программу, котрая на вход принимает два числа и выдает какое число большее, а какое меньшее

Console.Write("Input yoyr first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input yoyr second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());


if (number_1 > number_2)
{
    Console.WriteLine($"max={number_1}, min={number_2}");
}
else
{
    Console.WriteLine($"max={number_2}, min={number_1}");
}

