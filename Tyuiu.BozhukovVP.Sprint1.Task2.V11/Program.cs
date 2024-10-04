using Tyuiu.BozhukovVP.Sprint1.Task2.V11.Lib;
namespace Tyuiu.BozhukovVP.Sprint1.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 Выполнил: Божуков В. П. ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Божуков В. П. ИБКСб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УCЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Формулировка задания: Задано текущее время в часах и минутах. Вычислить,*");
            Console.WriteLine("* сколько секунд прошло с начала суток.                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int hour;
            int minute;
            Console.WriteLine("Введите количество часов:");
            hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество минут:");
            minute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Секунд с начала суток прошло: " + ds.ConvertHoursMinutesToSeconds(hour, minute));
            Console.ReadLine();
        }
    }
}

