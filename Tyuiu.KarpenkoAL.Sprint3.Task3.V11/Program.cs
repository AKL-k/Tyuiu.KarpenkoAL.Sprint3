using Tyuiu.KarpenkoAL.Sprint3.Task3.V11.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: используя цикл foreach заменить буквы q на цифру 7  *");
Console.WriteLine("* в строке: sqwreq vqwqq q                                                *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "sqwreq vqwqq q";
char replaceable = 'q';
char replacement = '7';

Console.WriteLine("Исходная строка = " + value);
Console.WriteLine("Искомый символ = " + replaceable); 
Console.WriteLine("Новый символ = " + replacement);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Новая строка = " + ds.ReplaceCharOnNum(value, replaceable, replacement));

Console.ReadKey();

