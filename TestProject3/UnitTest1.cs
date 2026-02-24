using task3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace TestProject3.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void EmptyLine()
        {
            int count = Logic.СountIdenticalLetters("");
            Assert.AreEqual(0,count);
        }

        [TestMethod()]
        public void SringSpaces()
        {
            int count = Logic.СountIdenticalLetters(" ");
            Assert.AreEqual(0, count);
        }

        [TestMethod()]
        public void IdenticalCharactersSeparatedSpace()
        {
            int count = Logic.СountIdenticalLetters("d d");
            Assert.AreEqual(0, count);
        }

        [TestMethod()]
        public void IdenticalSymbolsNear()
        {
            int count = Logic.СountIdenticalLetters("dd");
            Assert.AreEqual(1, count);
        }
    }
}
