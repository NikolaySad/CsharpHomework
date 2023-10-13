/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
System.Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;
if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}
if (firstNumber * 10 + firdNumber);

Console.WriteLine(result);
