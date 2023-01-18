// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5 78 -> третьей цифры нет

int InputInt(string message)
{
  Console.WriteLine(message + " > ");
  string? inputValue = Console.ReadLine();
  int result = Convert.ToInt32(inputValue);
  return result;
}

bool ValidateNumberRank3(int number)
{
  if (number > 99 && number < 1000)
  {
    return true;
  }
  System.Console.WriteLine("Третьей цифры нет.");
  return false;
}

int number = InputInt("Введите трехзначное число");
if (ValidateNumberRank3(number))
{
  int Rank = number % 10;
  System.Console.WriteLine($"третья цифра числа {number} равна {Rank}");
}