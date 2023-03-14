/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N
*/

int GetNumberFromUser(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool NaturalNumber(int a, int b)
{
    if(a < 0 || b < 0) return false;
    else return true;
}

void NaturalNumbersSum(int min, int max)
{
    int sum = 0;
    while(max >= min)
    {
        sum = sum + min;
        min++;
    }
    Console.WriteLine($"Результат: {sum}");
}

int m = GetNumberFromUser("Задайте значение 1 > ");
int n = GetNumberFromUser("Задайте значение 2 > ");
if (NaturalNumber(m, n))
{
    if(m > n)  NaturalNumbersSum(n, m);
    else NaturalNumbersSum(m, n);
}
else Console.WriteLine("Одно из чисел не натуральное!");
