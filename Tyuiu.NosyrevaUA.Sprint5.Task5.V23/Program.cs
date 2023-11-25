using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NosyrevaUA.Sprint5.Task5.V23.Lib;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.Task5.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Носырева Ю. А.| ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Носырева Юлия Алексеевна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask5V23.txt (файл взять из архива   *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5   и      *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор значений.Найти минимальное *");
            Console.WriteLine("* вещественное число в файле. Полученный результат вывести на консоль.    *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V23";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Наименьшее вещественное число: " + res);
            Console.ReadKey();
        }
    }
}
