Console.Write("Введите ваше имя: ");
string userName = Console.ReadLine();
if (userName.ToLower() == "маша") {
    Console.WriteLine("Привет, Машуля!!!");
} else {
    Console.WriteLine("Добрый день, " + userName + "!");
}