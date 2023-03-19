int Promp (string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int number = Promp("Введите трехзначное число: ");
if (number < 100 || number>=1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, попробуйте еще раз");
    return;
}
else
{
    int secondValue = ((number / 10) % 10);
    Console.WriteLine($"В числе {number} вторая цифра {secondValue}");
}