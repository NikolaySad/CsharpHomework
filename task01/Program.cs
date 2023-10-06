/*
1. напишите программу, которая на вход принимает два числа и проверяет, является ли первое числоквадратом второго.

a = 25; b = 5 -> да
a = 2; b = 10 -> нет
a = 9; b = -3 -> да
a = -3; b = 9 -> нет
*/

System.Console.Writeline("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());

System.Console.Writeline("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 / number2 == number2 || number2 / number1 == number1)
{
    Console.Writeline("Yes");
}
else
{
    Console.Writeline("NO");
}
