using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint4.Task2.V12.Lib;

namespace Tyuiu.BeketovVN.Sprint4.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 6, 5, 8, 7, 4, 9, 5, 6, 4, 7, 9, 8, 5, 6 };

            int res = ds.Calculate(numsArray);
            int wait = 47;
            Assert.AreEqual(wait, res);
        }
    }
}
