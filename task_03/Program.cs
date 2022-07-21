// 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8" 

void Nat(int numStart, int numFin)
{
    if (numStart > numFin) return;
    Console.Write(numStart + " ");
    Nat(numStart + 1, numFin);
}

(int numStart, int numFin) MinMax (int numStart, int numFin)
{
    int temp;
    if (numStart > numFin)
    {
        temp = numStart;
        numStart = numFin;
        numFin = temp;
    }
    return(numStart, numFin);
}

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
(m, n) = MinMax(m, n);
Nat(m, n);