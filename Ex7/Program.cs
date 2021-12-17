//Потемкин Кирилл

//a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b).
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

Console.WriteLine("Введите a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
int b = Convert.ToInt32(Console.ReadLine());
int c = 0;
if (a > b) (a, b) = (b, a);
Console.WriteLine("");

Console.WriteLine($"\n{Nums(a, b, c)}");

int Nums(int a, int b, int c)
{
    Console.WriteLine(a);
    c += a;
    if (a < b) c = Nums(a + 1, b, c);
    return c;
}
