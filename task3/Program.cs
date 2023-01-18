// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
int InputInt(string message)
{
  Console.WriteLine(message + " > ");
  string? inputValue = Console.ReadLine();
  int result = Convert.ToInt32(inputValue);
  return result;
}

bool ValidateNumberDay(int number)
{
  if (number > 5 && number < 8)
  {
    return true;
  }
  System.Console.WriteLine("День не выходной");
  return false;
}

int number = InputInt("Введите день недели");
if (ValidateNumberDay(number))
{
  int Day = number;
  Console.WriteLine("День выходной");
}