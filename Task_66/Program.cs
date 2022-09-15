Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(SummaRec(b, a));

int SummaRec(int N, int M)
{
    if (N == M) return M;
    return N + SummaRec(N - 1, M);
}

