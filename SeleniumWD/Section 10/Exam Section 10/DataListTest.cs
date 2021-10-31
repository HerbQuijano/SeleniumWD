using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace SeleniumWD.Section_10.Exam_Section_10
{
    [TestClass]
    public class DataListTest
    {
        ArrayList dataList = new ArrayList();
        

        [TestMethod]
        public void TestMethod1()
        {
            ArrayList sortedList = new ArrayList();
            double total = 0;

            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add(13.5);
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball Soup");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");

            sortedList = DataList.SortData(dataList);
            total = DataList.TotalNums(sortedList);

            //Console.WriteLine(total);
            Assert.AreEqual(147, total, 0.1);

               
            






        }
    }
}
