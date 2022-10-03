Console.Write("Введите первое число: ");
string firstString = Console.ReadLine();
int numberA = Convert.ToInt32(firstString);
Console.Write("Введите второе число: ");
string secondString = Console.ReadLine();
int numberB = Convert.ToInt32(secondString);
int sum = numberA + numberB;
Console.WriteLine("Сумма двух чисел равна: " + sum);
