/*
46. Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
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
            array[i,j] = new Random().Next(100);
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




/* Console.Clear();
int[,] GetRnd(int)
{
    int[] array = new int[size];
    for (int i = 0; i < array.GetLength; i++)
  {  
     array[i] = new Random().Next(0,10);
  }
  return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("[");
    for(int i = 0; i < arr.Length; i++)
    {
    Console.ForegroundColor = ConsoleColor.Green;
    Thread.Sleep(1);
    Console.WriteLine(arr[i]);
    if (i < arr.Length -1 )
        Console.WriteLine(", ");
    }
    Console.Write

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("]"); 
}
*/

