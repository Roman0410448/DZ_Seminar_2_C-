// Задача 13: Напишите программу, которая выводит третью цифру числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = Prompt("Введите число не меньше трехзначного: ");
int count = number.ToString().Length;
Console.Write($"В числе {number} третья цифра {MakeArray(number, count)}");
int Prompt (string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int MakeArray(int a, int b)
{
int result = -1;
    if (b < 3)
    {
        Console.Write("Вы ввели не трехзначное число, попробуйте еще раз  ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}