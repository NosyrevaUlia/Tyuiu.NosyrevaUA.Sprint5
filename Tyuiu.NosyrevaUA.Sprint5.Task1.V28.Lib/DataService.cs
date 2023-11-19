using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NosyrevaUA.Sprint5.Task1.V28.Lib
{
    public class DataService : ISprint5Task1V28
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string str;
            for (int x = startValue; x <= stopValue; x++)
            {
                if( x == 0.7)
                { return "0"; }
                else
                {
                    y = (Math.Cos(x) / (x - 0.7)) - (Math.Sin(x) * 12 * x + 2);
                    y = Math.Round(y, 2);
                    str = Convert.ToString(y);

                    if (x != stopValue)
                    {
                        File.AppendAllText(path, str + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, str);
                    }
                }               
            }
            return path;

        }
    }
}
