using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint0.Review.Lib;

namespace Tyuiu.IvanchikovDA.Sprint0.Review.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(35, DataService.Calc(2, 2, 3));
        }
    }
}