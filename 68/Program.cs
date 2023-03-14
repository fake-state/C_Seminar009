/*
Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/

int GetNumberFromUser(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool PositiveNumbers(int m, int n)
{
    if(m < 0 || n < 0) return false;
    else return true;
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
        else if (n == 0 && m != 0) return Akkerman(m - 1, 1);
        else if (n > 0 && m > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
        return 0;
}

Console.WriteLine("Вычисление функции Аккермана A(m,n): ");
int m = GetNumberFromUser("Введите неотрицательное число m > ");
int n = GetNumberFromUser("Введите неотрицательное число n > ");
if (PositiveNumbers(m, n))
{
    
    Console.WriteLine($"Результат: {Akkerman(m,n)}");
}
else Console.WriteLine("Использованы отрицательные значения!");