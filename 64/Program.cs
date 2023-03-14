/*  
Задайте значение N. Напишите программу, 
которая выведет все натуральные числа
в промежутке от N до 1. Выполнить с помощью рекурсии. 
*/

int GetNumberFromUser(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool NaturalNumber(int number)
{
    if(number > 0) return true;
    else return false;
}

void ValuesFromNToOne(int number)
{
    
    if(number > 0)
    {
        Console.Write(number + " ");
        ValuesFromNToOne(number - 1);
    } 
}

int n = GetNumberFromUser("Введите число > ");
Console.WriteLine("Результат: ");
if(NaturalNumber(n)) ValuesFromNToOne(n);
else Console.WriteLine("Введено отрицательное число");