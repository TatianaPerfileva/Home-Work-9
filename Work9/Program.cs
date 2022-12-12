Console.WriteLine("Zadacha64 \t");
void Zadacha64()
{
    // Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
    // который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    // M = 1; N = 9. -> "3, 6, 9"
    // M = 13; N = 20. -> "15, 18"

    Console.WriteLine("Введите натуральное число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите натуральное число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m <= 0 || n <= 0) Console.WriteLine("Ошибка ввода");
    if (m > 0 & n > 0)
    {
        int min = 1;
        int max = 1;
        if (m < n)
        {
            min = m;
            max = n;
        }
        else
        {
            min = n;
            max = m;
        }
        int counter = min;
        Console.WriteLine($"Числа, кратные 3 в промежутке от {m} до {n}");
        FindMultipleRecursion(max, counter);
    }
}

Zadacha64();

void FindMultipleRecursion(int max, int counter)
{
    if (counter > max) return;
    if (counter % 3 == 0)
        Console.Write($"{counter}    ");
    counter++;
    FindMultipleRecursion(max, counter);
}
Console.WriteLine();
Console.WriteLine("Zadacha66 \t");
void Zadacha66()
{
    // Задача 66: Задайте значения M и N. Напишите рекурсивный метод, 
    // который найдёт сумму натуральных элементов в промежутке от M до N.
    // M = 1; N = 15 -> 120
    // M = 4; N = 8. -> 30
    Console.WriteLine("Введите натуральное число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите натуральное число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m <= 0 || n <= 0) Console.WriteLine("Ошибка ввода");
    if (m > 0 & n > 0)
    {
        int min = 1;
        int max = 1;
        int sum = 0;
        if (m < n)
        {
            min = m;
            max = n;
        }
        else
        {
            min = n;
            max = m;
        }
        Console.WriteLine($"Сумма всех натуральных элементов от {m} до {n}");
        FindSumRecursion(max, min, sum);
    }
}

Zadacha66();
void FindSumRecursion(int max, int min, int sum)
{
    if (min > max)
    {
        Console.WriteLine(sum);
        return;
    }
    sum += min;
    min++;
    FindSumRecursion(max, min, sum);
}
Console.WriteLine("Zadacha68 \t");
void Zadacha68()
{
    // Задача 68: Напишите программу вычисления функции Аккермана с 
    // помощью рекурсии. Даны два неотрицательных числа m и n. 
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29
    Console.WriteLine("Введите натуральное число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите натуральное число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Ошибка ввода");
    }

    if (m >= 0 || n >= 0)
    {
        FindAkkermanFunction(m, n);
        Console.WriteLine($"Число функции Аккермана = {FindAkkermanFunction(m, n)}");
    }
}

Zadacha68();

static int FindAkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return FindAkkermanFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return FindAkkermanFunction(m - 1, FindAkkermanFunction(m, n - 1));
    }
    else
        return n + 1;
}
