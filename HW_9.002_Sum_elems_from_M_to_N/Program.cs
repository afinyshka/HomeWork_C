// Найти сумму элементов от M до N, N и M заданы

int SumFromMtoN(int n, int m)
{
    if (n == m) return m;
    else return (SumFromMtoN(n, m - 1) + m);
    
}

int summa = SumFromMtoN(10, 15);
Console.WriteLine($"Summa of the numbers from M to N equals = {summa} ");