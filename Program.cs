﻿/* Напишите программу, которая выводит случайное трёхзначное число и удаляет
вторую цифру этого числа.
Например: 456 -> 46,  782 -> 72,  918 -> 98
*/

Ranom ranom == new Random();
int number = random.Next(100, 1000);
Console.WriteLine(number);

int first = number / 100;
int last = number % 10;
int result = first * 10 + last;

int result = first * 10 + last;

Console.WriteLine(result);
