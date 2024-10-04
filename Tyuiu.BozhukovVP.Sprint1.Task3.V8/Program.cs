using Tyuiu.BozhukovVP.Sprint1.Task3.V8.Lib;
namespace Tyuiu.BozhukovVP.Sprint1.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 Выполнил: Божуков В. П. ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Божуков В. П. ИБКСб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УCЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double percent = 20;
            double startAmount = 2500;
            double timeDays = 30;
            Console.WriteLine("Величина вклада (руб.)-> " + startAmount);
            Console.WriteLine("Срок вклада (дней)-> " + timeDays);
            Console.WriteLine("Процентная ставка (годовых)-> " + percent);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double doh = ds.IncomeAmount(startAmount, percent, timeDays);
            double x = doh - startAmount;
            double xot = Math.Round(x, 3);
            Console.WriteLine("Сумма по окончанию срока вклада: " + xot);
            Console.WriteLine("Доход: " + doh);
            Console.ReadKey();
        }
    }
}
