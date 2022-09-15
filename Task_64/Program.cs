Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(b, a));

string Sum(int N, int M)
{
    if (N == M) return $"{M} ";
    return Sum(N - 1, M) + N + " ";
}
