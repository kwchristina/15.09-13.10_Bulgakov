// Задача 4. Найти максимальное из трех чисел

Console.Write("Enter the first number:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number:  ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number:  ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = (num1);
if (num2 < num1) max = num1;
else if (num3 < num2) max = num2;
else if (num3 < num1) max = num1;
else if (num1 < num3) max = num3;
Console.WriteLine($"Maximum number: {max}");
