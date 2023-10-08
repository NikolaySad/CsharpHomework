/* Внутри класса Answer напишите метод CheckIfEven,
** который на вход принимает число number и выводит, является ли число четным (делится ли на два без остатка).
*/
 
 System.Console.WriteLine("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 
    if (number % 2 == 0)
    {
        System.Console.WriteLine("Четное число: ");
    }
    else 
    {
        System.Console.WriteLine("Нечетное число: ");
    }
    
