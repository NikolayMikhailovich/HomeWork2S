//Программа которая показывает вторую цифру числа или сообщает что второй цифры нет.

Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 1)
{
  Console.WriteLine("Вторая цифра -> " + anyNumberText[1]);
}
else
{
  Console.WriteLine("-> Второй цифры нет");
}

