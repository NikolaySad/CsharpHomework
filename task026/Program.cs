﻿/* Задача 26: Напишите программу, которая принимает
 на вход число и выдаёт количество цифр в числе.
 456 -> 3
 78 -> 2
 89126 -> 5
*/
Console.Clear();

int CountDigits(int numb)
{
   if (numb == 0) return 1;
   int count = 0;
   while (numb != 0)
    {
        numb = numb / 10;
        count = ++;
    }
    return i;
}

Console.WriteLine("Ведите целое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
int result = CountDigits(numb1);
System.Console.WriteLine($"В числе {numb1} -> {result} цифра(a)");