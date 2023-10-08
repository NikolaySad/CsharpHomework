using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    
        // Введите свое решение ниже

      Console.WriteLine(«Введите число»);
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
System.Console.WriteLine(«Число: » + a + » четное»);
else System.Console.WriteLine($»Число: {a} нечетное»);
      

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}