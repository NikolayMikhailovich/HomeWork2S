// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int InputInt(string message)
{
  Console.WriteLine(message + " > ");
  string? inputValue = Console.ReadLine();
  int result = Convert.ToInt32(inputValue);
  return result;
}

bool ValidateNumberRank2(int number)
{
  if (number > 99 && number < 1000)
  {
    return true;
  }
  System.Console.WriteLine("Число не трехзначное.");
  return false;
}

int number = InputInt("Введите трехзначное число");
if (ValidateNumberRank2(number))
{
  int Rank = number % 100/10;
  System.Console.WriteLine($"Вторая цифра числа {number} равна {Rank}");
}