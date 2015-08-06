using asp.net.digilevich.kontrolnaya.binarnoe_derevo_poiska;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace testforbinarytree
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_remove()
        {
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Add(10);

            Assert.AreEqual(true, bt.Remove(10));
        }
    }
}
