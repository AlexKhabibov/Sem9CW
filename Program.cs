// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

/*
void ShowNumbers (int n)
{
    if (n > 1) ShowNumbers (n-1);
    Console.Write(n + " ");
}

ShowNumbers(5);

void ShowNumRange(int n, int m)
{
    if (Math.Max(n, m) != Math.Min(n, m))
    ShowNumRange(Math.Min(n, m), Math.Max(n, m) - 1);
    Console.Write($"{Math.Max(n, m)} ");
}

ShowNumRange(10, 20);
*/

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 8; N = 4 -> "4, 6, 7, 8"

/*
void ShowNumRange(int n, int m)
{
    if (n != m) ShowNumRange(Math.Min(n, m), Math.Max(n, m) - 1);
    Console.Write($"{Math.Max(n, m)} ");
}
ShowNumRange(10, 20);
*/

// Напишите программу, которая будет принимать на вход число и будет возвращать сумму его цифр
// 453 -> 12
// 45 -> 9

/*
int SumDigits (int n)
{
    if (n < 0) n *= (-1);
    if (n == 0) return 0;
    return SumDigits(n/10) + n % 10;
}

Console.WriteLine("Enter num: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits(n);
Console.Write($"Your sum is: {sum}");
*/

// Напишите программу, которая на вход принимает два числа  a и b, и возводит число A в целую степень B с помощью рекурсии.

/*
double FindPow(int a, int b)
{
    if (b == 0) return 1.0;
    if (b > 0) return FindPow(a, b -1) * a;
    return FindPow(a, b + 1) / a;
}

double res = FindPow (2, -3);
Console.WriteLine(res);
*/

// Напишите программу, которая на вход принимает положительное целое десятичное число, а на выходе выводит это же число, но в бинарном виде.
// 4 -> 0100
// 5 -> 0101

/*
string DecToBin (int n, ref string s)
{
    if (n>0)
    {
        DecToBin(n/2, ref s);
        s += (n%2).ToString();
    }
    if (n == 0) return s;
    return s;
}

Console.WriteLine("Enter num: ");
int n = Convert.ToInt32(Console.ReadLine());
string s = " ";
string sum = DecToBin(n, ref s);
Console.Write(sum);
*/