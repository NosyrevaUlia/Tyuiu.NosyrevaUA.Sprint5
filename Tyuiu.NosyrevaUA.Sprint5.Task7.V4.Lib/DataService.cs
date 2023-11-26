using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4

    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V4.txt";

            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileex = fileInfo.Exists;
            if (fileex)
            {
                File.Delete(pathSave);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string forbid = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщъыьЭэЮюЯя";
                string str = reader.ReadLine();
                string res = "";

                StringBuilder res1str = new StringBuilder(str);
                for ( int i = 0; i < res1str.Length; i++)
                {
                    for (int j = 0; j < forbid.Length; j++)
                    {
                        if (res1str[i] == forbid[j])
                        {
                            res1str[i] = '#';
                        }
                    }
                }
                for (int i = 0; i < res1str.Length; i++)
                {
                    res += res1str[i];
                }
                File.AppendAllText(pathSave, res+Environment.NewLine);
                res = "";
            }
            return (pathSave);
        }
    }
}
