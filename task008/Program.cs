/* Внутри класса Answer напишите метод PrintEvenNumbers,
** который на вход принимает число (number),
** а на выходе выводит все четные числа от 1 доnumber (включительно), разделенные знаком табуляции.
*/
 

Console.WriteLine("Введие число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < number; i = i + 2) //всегда 3 показателя: точка входа; условие выхода из цикла...
{
    System.Console.Write(i + " \t");
}