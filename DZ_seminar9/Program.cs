// 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

void Nat(int numStart, int numFin)
{
    Console.Write(numStart + " ");
    if (numStart == numFin) return;
    if (numStart > numFin) Nat(numStart - 1, numFin);
    if (numStart < numFin) Nat(numStart + 1, numFin);
}

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Nat(m, n);

**************************************************************************************************************************

// 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNat (int a, int b)
{
    if (a > b) return 0;
    return SumNat(a + 1, b) + a;
}

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(SumNat(m, n));

************************************************************************************************************************

// 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
Console.WriteLine("Введите положительное число: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите положительное число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Akkerman(m, n));

