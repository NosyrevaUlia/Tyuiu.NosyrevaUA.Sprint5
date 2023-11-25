using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1000;
            using (StreamReader reader = new StreamReader(path + ".txt"))
            {
                int r;
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    if (!(int.TryParse(line, out r)))
                    {
                        if(res>(Convert.ToDouble(line)))
                        {
                            res = Math.Round(Convert.ToDouble(line), 3);
                        }
                        else { res = res; }
                    }
                    else { res = res; }
                      
                }
                return res;
            }
        }
    }
}
