using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint5.Task0.V13.Lib;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Юлия\source\repos\Tyuiu.NosyrevaUA.Sprint5\Tyuiu.NosyrevaUA.Sprint5.Task0.V13\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool w = true;
            Assert.AreEqual(w, fileExists);
            
        }
    }
}
