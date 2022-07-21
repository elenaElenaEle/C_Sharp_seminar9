// 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Power (int a, int b)
{
    if (b == 0) return 1;

    return Power (a, b-1) * a;
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую возвест число: ");
int power = int.Parse(Console.ReadLine());
Console.WriteLine(Power (number, power));