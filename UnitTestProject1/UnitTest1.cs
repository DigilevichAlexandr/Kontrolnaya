using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using asp.net.digilevich.kontrolnaya;


namespace unittestspace
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGet_Int_25()
        {
            TwoDirectionList<int> tdl = new TwoDirectionList<int>();
            tdl.Add(10);
            Assert.AreEqual(10, tdl.GetLast());
        }
    }
}
