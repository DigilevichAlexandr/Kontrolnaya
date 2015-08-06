using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HeshTable;

namespace UnitTestHashTable
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsEqualHashCode()
        {
            Assert.AreEqual(true,(new HeshTableClass(new[] { 1, 2, 3, 4, 5 })).IsHashEqual(12, 2));
        }
    }
}
