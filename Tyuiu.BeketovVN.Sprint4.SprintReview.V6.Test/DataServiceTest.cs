using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BeketovVN.Sprint4.SprintReview.V6.Lib;

namespace Tyuiu.BeketovVN.Sprint4.SprintReview.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string str = "458963214789";

            int res = ds.Calculate(n, m, str);
            int wait = 34;

            Assert.AreEqual(wait, res);

        }
    }
}
