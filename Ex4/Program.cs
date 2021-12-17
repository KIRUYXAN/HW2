//Потемкин Кирилл

//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел.
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
//программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.

// Login: root   Password: GeekBrains

int err = 3;
bool a = false;
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
        Console.WriteLine(a);
        err--;
        Console.WriteLine($"У вас осталось {err} попытки");
        Console.WriteLine("");
    }
} while (err != 0);
if (a == false) Console.WriteLine("Вы заблокированы");