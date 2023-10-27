﻿/*
51. Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

int[,] Get2DArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    } 
    return array;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] Sqare2DEven(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if(j % 2 == 0 & i % 2 == 0) arr1[i,j]*=arr1[i,j]; 
        }
    }
    return arr1;
}



int[,] user2DArray = Get2DArray(3,3);
Print2DArray(user2DArray);
int[,] u2DArray = Sqare2DEven(user2DArray);
System.Console.WriteLine();
Print2DArray(u2DArray);

