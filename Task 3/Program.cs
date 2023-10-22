// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.
int ReadInt(string msg)//Объявление функции.Функция ReadInt , параметр msg.
{
    System.Console.WriteLine(msg);  // Выводит на экран параметр msg
    string Num = Console.ReadLine(); //Функция считывания строки с консоли
    int Number;//Объявление переменной.
    Number = int.Parse(Num);//Как результат - преобразование строки в число
    return Number;//Возврат из функции
}
int DayNumber = ReadInt("Введите цифру дня недели");
if (DayNumber == 6 || DayNumber == 7)
{
    System.Console.WriteLine("Это выходной день");
}
else if (DayNumber < 6 && DayNumber > 0)
{
    System.Console.WriteLine("Это не выходной день");
}


