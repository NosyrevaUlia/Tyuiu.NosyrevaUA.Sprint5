using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint5.Task1.V28.Lib;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.Task1.V28.Tast
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Юлия\source\repos\Tyuiu.NosyrevaUA.Sprint5\Tyuiu.NosyrevaUA.Sprint5.Task1.V28\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool w = true;
            Assert.AreEqual(w, fileExists);
        }
    }
}
