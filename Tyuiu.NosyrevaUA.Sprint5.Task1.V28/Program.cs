using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NosyrevaUA.Sprint5.Task1.V28.Lib;

namespace Tyuiu.NosyrevaUA.Sprint5.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Носырева Ю. А.| ИИПб-23-3 ";
         
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнила: Носырева Юлия Алексеевна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = cos(x)/(x-0.7) - sin(x) * 12x + 2 (произвести       *");
            Console.WriteLine("* табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1. Произвести  *");
            Console.WriteLine("* проверку деления на 0. При делении на 0 вернуть значение 0. Результат   *");
            Console.WriteLine("* сохранить в текстовый файл OutPutFileTask1.txt  и вывести на консоль в  *");
            Console.WriteLine("* таблицу. Значения округлить до 2 знаков после запятой.                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string str = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + str);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}
