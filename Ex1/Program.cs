Console.WriteLine("Введи первое число: ");
int a = Convert.ToInt32(Console.ReadLine()); ;
Console.WriteLine("Введи второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b)
    if (a < c) Console.WriteLine($"{a} - минимальнное число");
    else Console.WriteLine($"{c} - минимальнное число");
else
    if (b < c) Console.WriteLine($"{b} - минимальнное число");
    else Console.WriteLine($"{c} - минимальнное число");