//Потемкин Кирилл

//*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
//«Хорошим» называется число, которое делится на сумму своих цифр.
//Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

double a = 0;
double b = 0;
double c = 0;
int good = 0;

double sh = DateTime.Now.Hour / 60;
double sm = (DateTime.Now.Minute + sh) / 60 ;
double ss = (DateTime.Now.Second + sm) / 1000;
double sms = DateTime.Now.Millisecond + ss;

for (double i = 1; i <= 1000000000; i++)       //Числа от 1 до 1000000000
{
    a = i;
    c = 0;
    Console.WriteLine($"i {i}");              // Инфо об        i
    while (a > 0)                              //Сумма цифр числа
    {
        b = a % 10;
        Console.WriteLine($"b {b}");         // Инфо о          b
        a = (a - b) / 10;
        Console.WriteLine($"a {a}");         // Инфо об         a
        c += b;
        Console.WriteLine($"c {c}");         // Инфо об         c
    }
    if (i % c == 0)  good++;
    Console.WriteLine($"good {good}");
}
double eh = DateTime.Now.Hour / 60;
double em = (DateTime.Now.Minute + eh) / 60;
double es = (DateTime.Now.Second+ em) / 1000;
double ems = DateTime.Now.Millisecond + es;

Console.WriteLine("");
Console.WriteLine($" \"Xороших\" чисел: {good}.\n Времени заняло: {(ems - sms) / 60000:F2} мин.");