//Написать метод подсчета количества цифр числа.

Console.WriteLine("Введи число");
double a = Convert.ToDouble(Console.ReadLine());
int z = 0;
double b = a;

while (b > 0)
{
    z++;
    b /= 10;
}
Console.WriteLine($"В числе {a}: {z} цифр");