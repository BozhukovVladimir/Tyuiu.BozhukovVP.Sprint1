using Tyuiu.BozhukovVP.Sprint1.Task6.V3.Lib;
namespace Tyuiu.BozhukovVP.Sprint1.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 Выполнил: Божуков В. П. ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Божуков В. П. ИБКСб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УCЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать строку,       *");
            Console.WriteLine("* составленную из последних литер всех слов.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите текст:");
            string value = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string result = ds.LastLetterWord(value);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}