using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.Task2.V9.Lib
{
    public class DataService : ISprint5Task2V9
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool Fileex = fileInfo.Exists;

            if(Fileex)
            { File.Delete(path); }

            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i,j] % 2 == 1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j!= col - 1)
                    {
                        str = str + matrix[i, j]+ ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else { File.AppendAllText(path, str); }

                str = "";
            }
            return path;

        }
    }
}
