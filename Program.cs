// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число: ");
int seconRank = number / 10 % 10;
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, повторите ввод");
    return;
}

Console.WriteLine(seconRank);