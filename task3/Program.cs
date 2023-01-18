// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.

Console.WriteLine("введите номер дня недели");
string dayofweek = Console.ReadLine();
int numberday = Convert.ToInt32(dayofweek);

if (numberday < 8 && numberday > 0)
{
  string[] weeks = new string[7] { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
  Console.WriteLine(weeks[numberday - 1]);
}
else Console.WriteLine("Это не день недели");

if (5 < numberday && numberday < 8)
{
  Console.WriteLine("День является выходным");
}
else System.Console.WriteLine("День будний");
if (numberday < 1 && numberday > 7)
{
  Console.WriteLine("Это не день недели");
}