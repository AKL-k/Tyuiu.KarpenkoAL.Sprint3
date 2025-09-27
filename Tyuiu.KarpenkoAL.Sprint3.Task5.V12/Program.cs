using Tyuiu.KarpenkoAL.Sprint3.Task5.V12.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Вложенные циклы                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя вложенный цикл, которая вычисляет сумму су *");
Console.WriteLine("* мм ряда пo формуле, при х=5                                             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 5;
int startValue1 = 1;
int stopValue1 = 3;
int startValue2 = 1;
int stopValue2 = 10;

Console.WriteLine("Переменная Х = " + x);
Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
Console.WriteLine("Конец шага второй суммы ряда = " + stopValue2);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма сумм ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

Console.ReadKey();
