// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка)

Console.Write("input your  number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
  Console.WriteLine("Your number is even");  
}
else
{
    Console.WriteLine("Your number is odd"); 
}
