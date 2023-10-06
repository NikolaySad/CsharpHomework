/*
1. напишите программу, которая на вход принимает два числа и проверяет, является ли первое числоквадратом второго.

a = 25; b = 5 -> да
a = 2; b = 10 -> нет
a = 9; b = -3 -> да
a = -3; b = 9 -> нет
*/

System.Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 / number2 == number2 || number2 / number1 == number1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("NO");
}
