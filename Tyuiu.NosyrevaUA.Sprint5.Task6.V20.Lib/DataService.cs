using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadToEnd();
                string[] linestr = line.Split();
                int count = 0;
                for(int i = 0; i<linestr.Length-1; i++)
                {
                    if(linestr[i].Length == 6)
                    { count++; }
                }
                if(linestr[linestr.Length-1].Length == 7)
                { count++; }
               
                

                return count;
            }
        }
    }
}
