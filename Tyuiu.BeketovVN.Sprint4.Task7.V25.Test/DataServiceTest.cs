using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint4.Task7.V25.Lib;

namespace Tyuiu.BeketovVN.Sprint4.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int startValue = 3;
            int stopValue = 4;
            int[,] mtrx = new int[startValue, stopValue];
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double wait = 38;
            Assert.AreEqual(wait, res[0]);
        }
    }
}
