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