/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void CheckDay(int number)
{
    if (number < 6)
    Console.WriteLine("Нет. Это рабочий день");

    else
    Console.WriteLine("Да. Выходной!");
}

int number = GetNumber("Введите номер дня недели: ");

CheckDay(number);