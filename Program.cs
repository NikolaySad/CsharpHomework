﻿/*  33. Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

System.Console.WriteLine("Укажите массив, каждый элемент которого указан через запятую");

 string massive = System.Console.ReadLine(); 
   
int size - 1;

foreach(char a in massive)
    if (a== ',') size++;

int[] newArray = int[size];

for(int i = 0; i < newArray.Length; i ++)
{
    string number = "";

    for(int j =0; j < massive.Length; j++)
}
