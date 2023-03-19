//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

 int Prompt (string message)
 {
     System.Console.Write(message);
     int result = Convert.ToInt32(Console.ReadLine());
     return result;
 }
 int number = Prompt("Введите трехзначное число: ");
 if (number < 100 || number >= 1000)
 {
     Console.WriteLine("Вы ввели не трехзначное число, попробуйте еще раз");
     return;
 }
 else
 {
     int secondValue = ((number / 10) % 10);
     Console.WriteLine($"В числе {number} вторая цифра {secondValue}");
 }

