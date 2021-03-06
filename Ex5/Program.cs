/*а) Написать программу, которая запрашивает массу и рост человека,
вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
б) Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/

/*ИМТ
Понижженый: <18,5
Нормалльный: 18,5 - 25,0
Повышены:й 25,0 - 30,0
Избыточный: >30,0*/

Console.WriteLine("Давайте вычеслим ваш ИМТ");
Console.WriteLine("Введите ваше вес в кг:");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вашу рост в см: ");
double h = Convert.ToDouble(Console.ReadLine()) / 100;
string text = "";

double bmi = m / (h * h);                      //body mass index
double normm = (21.75 / (h * h)) * 2;         //normal midle

if (bmi < 18.5)
    text = $"Пониженый. Вам надо набрать {normm:F2} кг для нормального ИМТ";
else if (bmi > 18.5 && bmi < 25)
    text = $"Нормальный";
else if (bmi > 25 && bmi < 30 )
    text = $"Повышеный. Вам надо похудеть на {normm:F2} кг для нормального ИМТ";
else
    text = $"Избыточный. Вам надо збросить {normm*2:F2} кг для нормального ИМТ";
Console.WriteLine("");
Console.WriteLine($"Ваш ИМТ: {bmi:F2}\n{text}");