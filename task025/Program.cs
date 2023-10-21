/*Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
Console.WriteLine("Число А в натуральной степени В.");
Console.WriteLine("Введите число А, возводимое в степень число: ");
int nA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В - степень в которую необходимо возвести: ");
int nB = Convert.ToInt32(Console.ReadLine());

int Exponent(int number, int degree)
{
    int exponentNumber = number;
    for (int i = 1; i < degree; i++)
    {
        exponentNumber = exponentNumber * nA;
    }
    return exponentNumber;
}

void PrintResult(int result)
{
    Console.WriteLine($"Число {nA} в натуральной степени {nB} дает число {result}");
}

int res = Exponent(nA, nB);
PrintResult(res);