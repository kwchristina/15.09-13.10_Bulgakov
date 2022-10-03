// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Enter integer: ");
int number = Convert.ToInt32(Console.ReadLine());
string count = Convert.ToString(number);

if (count.Length > 2)
{
    Console.WriteLine($"Third digit: {count[2]}");
}
else Console.WriteLine("No third digit");
