using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using L2;

namespace UnitTestMerge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] masNoSort =new int[] { 66, 74, 50, 55, 91, 95, 69, 84, 38, 34 };
            int[] masSort =new int[] { 34, 38, 50, 55, 66, 69, 74, 84, 91, 95 };
            
            int[] sort = L2.Program.MergeSort(masNoSort);

            Assert.AreEqual(sort,masSort);
        }
    }
}
