Console.Write("Введите число M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(AkkermanFunc(n, m)); 

int AkkermanFunc(int n, int m)
{
    if (n < 0 || m < 0) throw new ArgumentOutOfRangeException("Вы ввели отрицательное число");
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return AkkermanFunc(n - 1, 1);
    else return AkkermanFunc(n - 1, AkkermanFunc(n, m - 1));
}