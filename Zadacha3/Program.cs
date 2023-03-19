// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt (string message)
{
     System.Console.Write(message);
     int result = Convert.ToInt32(Console.ReadLine());
     return result;
}
int DayWeek = Prompt("Введите день недели от 1 до 7: ");
if (DayWeek >= 1 && DayWeek <=7) 
{
	if (DayWeek >= 6) 
    {
		Console.Write("УРА, ВЫХОДНОЙ!!!");
	} 
    else
    {
		Console.Write("НА РАБОТУ");
	}
} 
else 
{
	Console.Write("Такого дня недели нет ");
}