//Потемкин Кирилл

//*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
//«Хорошим» называется число, которое делится на сумму своих цифр.
//Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

double a = 0;
double b = 0;
double c = 0;
int good = 0;

DateTime st = DateTime.Now;

for (double i = 1; i <= 1000000000; i++)       //Числа от 1 до 1000000000
{
    a = i;
    c = 0;
    Console.WriteLine($"i {i}");              // Инфо об        i
    while (a > 0)                              //Сумма цифр числа
    {
        b = a % 10;
        Console.WriteLine($"b {b}");         // Инфо о          b
        a = (a-b) / 10;
        Console.WriteLine($"a {a}");         // Инфо об         a
        c += b;
        Console.WriteLine($"c {c}");         // Инфо об         c
    }
    if (i % c == 0)  good++;
    Console.WriteLine($"good {good}");
}
Console.WriteLine("");
Console.WriteLine($" \"Xороших\" чисел: {good}.\n Времени заняло: {(DateTime.Now - st).TotalMilliseconds:F2} мин.");