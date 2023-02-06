// Задача 8. Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.

Console.Write("input your number N: ");
int num_N = Convert.ToInt32(Console.ReadLine());
int current_num_N = 1;
while(current_num_N <= num_N)
{
    if (current_num_N % 2 == 0)
    Console.Write(current_num_N +" ");
    current_num_N++;
}

