int numberA = new Random().Next(1,10); // 1 2 3 4 ... 9
Console.WriteLine("Первое число равно: " + numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine("Второе число равно: " + numberB);
int sum = numberA + numberB;
Console.WriteLine("Сумма двух чисел равна: " + sum);

// Вариант с введением чисел через консоль!
// Console.Write("Введите первое число: ");
// string firstString = Console.ReadLine();
// int numberA = Convert.ToInt32(firstString);
// Console.Write("Введите второе число: ");
// string secondString = Console.ReadLine();
// int numberB = Convert.ToInt32(secondString);
// int sum = numberA + numberB;
// Console.WriteLine("Сумма двух чисел равна: " + sum);
