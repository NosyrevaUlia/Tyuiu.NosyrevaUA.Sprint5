using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint5.Task6.V20.Lib;
using System.IO;

namespace Tyuiu.NosyrevaUA.Sprint5.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedfileExist()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V20.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileex = fileInfo.Exists;
            Assert.AreEqual(fileex, true);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V20.txt";
            var res = ds.LoadFromDataFile(path);
            int w = 2;
            Assert.AreEqual(res, w);
        }
    }
}
