// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// Не использовать строки для расчета.

int ReadInt(string msg)//Объявление функции.Функция ReadInt , параметр msg.
{
    System.Console.WriteLine(msg);  // Выводит на экран параметр msg
    string Num = Console.ReadLine(); //Функция считывания строки с консоли
    int Number;//Объявление переменной.
    Number = int.Parse(Num);//Как результат - преобразование строки в число
    return Number;//Возврат из функции
}
int Number = ReadInt("Введите трёхзначное число");
if (Number < 1000 && Number > 99)
{
    int secondDigit = (Number % 100 - Number % 10) / 10;
    System.Console.WriteLine(" Вторая цифра " + secondDigit );
}
else System.Console.WriteLine("Это число не трёхзначное");
