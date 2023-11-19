using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint5.Task3.V30.Lib;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Юлия\source\repos\Tyuiu.NosyrevaUA.Sprint5\Tyuiu.NosyrevaUA.Sprint5.Task3.V30\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool w = true;
            Assert.AreEqual(w, fileExists);
        }
    }
}
