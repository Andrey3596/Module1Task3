using NUnit.Framework;
using task3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject3.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void Test()
        {
            string s = "";
            int count = Logic.СountIdenticalLetters(s);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0,count);
        }
        public void Test1()
        {
            string s = "  ";
            int count = Logic.СountIdenticalLetters(s);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, count);
        }
        public void Test2()
        {
            string s = "d d";
            int count = Logic.СountIdenticalLetters(s);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, count);
        }
        public void Test3()
        {
            string s = "dd d";
            int count = Logic.СountIdenticalLetters(s);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, count);
        }
    }
}
