using System;

namespace ConsoleApp5
{
  internal class Program
  {
    static void Main()
    {
      // 1-ая часть задания
      Console.Write("Задание 1.1.\nВведите число a: ");
      int numberA = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите n-степень: ");
      int exponentN = Convert.ToInt32(Console.ReadLine());

      // Число должно быть натуральным, проверяем чтобы n < 0
      if (exponentN < 0)
      {
        Console.WriteLine("Степень не может быть отрицательной!");
      }
      else
      {
        int result = 1;

        for (int index = 0; index < exponentN; ++index)
        {
          result *= numberA;
        }

        Console.WriteLine($"Введенное число {numberA}^{exponentN} = {result}");
      }
      // Очистка консоли перед следующим заданием, если надо
      // Console.Clear();

      // 2-ая часть задания
      Console.Write("\nЗадание 1.2.\nВведите число X (трехзначное или более): ");

      //Ввод должен быть целым числом и >= 100, в противном случае - ошибка!
      if (int.TryParse(Console.ReadLine(), out int numX) && numX >= 100)
      {
        // Число нужно преобразовать в строку
        string xAsString = numX.ToString();

        // Строка - последовательность символов (char), получаем вторую цифру числа
        char secondDigit = xAsString[1];
        // Берем подстроку с индекса 0 длиной 1, т.е. первый символ (метод Substring возвращает часть исходной строки)
        string resultWithoutSecondDigit = xAsString.Substring(0, 1) + xAsString.Substring(2);
        // Добавляем вторую цифру в конец 
        string resultAsString = resultWithoutSecondDigit + secondDigit;
        // Получаем число из новой строки
        int result = int.Parse(resultAsString);

        Console.WriteLine($"Новое число N: {result}");
      }
      else
      {
        Console.WriteLine("Ошибка. Число не может быть меньше 100");
      }
      Console.Write("Нажмите любую клавишу, чтобы закрыть окно...");
      Console.ReadKey();
    }
  }
}
