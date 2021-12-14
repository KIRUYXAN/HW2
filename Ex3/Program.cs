int s = 0;
int a = 0;
do
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a > 0 && a % 2 > 0) s += a;
} while (a != 0);
Console.WriteLine($"Сумма:  {s}");