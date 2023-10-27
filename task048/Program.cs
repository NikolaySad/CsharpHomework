/*
48. Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
*/

int[,] arr = CreateArray(3,3);

PrintMatrix(arr);

int[,] CreateArray(int rank0, int rank1)
{
    int[,] array = new int[rank0, rank1];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }        
    }
    return array;
}


void PrintMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "\t");
        }        
        System.Console.WriteLine();
    }
}
