int err = 3;
bool a;
do
{
    Console.WriteLine("Введите логин");
    string log = Console.ReadLine();
    Console.WriteLine("Введите пароль");
    string passw = Console.ReadLine();
    if (log == "root" && passw == "GeakBrains")
    {
        a = true;
        Console.WriteLine(a);
        err = 0;
    }
    else
    {
        a = false;
        Console.WriteLine(a);
        err--;
        Console.WriteLine($"У вас осталось {err} попытки");
        Console.WriteLine("");
    }
} while (err != 0);
if (a == false) 
    Console.WriteLine("Вы заблокированы");