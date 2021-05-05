using EXO2._1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnitTestProjectEXO2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Tri()
        {
            List<double> list = new List<double>();
            list.Add(20);
            list.Add(201);
            list.Add(11);
            list.Add(5);
            list.Add(44);
            list.Add(-12);
            CollectionAssert.AreEqual(Trier.Tri2(ref list), list);
           
            //CollectionAssert.AreNotEqual(newList, list);
        }


        [TestMethod]
        public void TestMethod2()
        {
        }
    }
}
