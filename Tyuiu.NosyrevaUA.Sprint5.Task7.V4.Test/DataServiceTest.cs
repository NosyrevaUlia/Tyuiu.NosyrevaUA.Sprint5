using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint5.Task7.V4.Lib;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedfileExist()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V4.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileex = fileInfo.Exists;
            Assert.AreEqual(fileex, true);
        }
    }
}
