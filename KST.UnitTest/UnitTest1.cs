using System;
using System.IO;
using KST.Manager.Implementation;
using KST.Manager.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KST.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        static string fileResult = "sorted-names-list.txt";

        [TestInitialize()]
        public void Startup()
        {
            if (File.Exists(fileResult))
            {
                File.Delete(fileResult);
            }
        }

        [TestCleanup()]
        public void Cleanup()
        {
            if (File.Exists(fileResult))
            {
                File.Delete(fileResult);
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            INameManager nameManager = new NameManager();
            nameManager.SortAllNames("TestFiles\\unsorted-names-list.txt");
            Assert.IsTrue(File.Exists(fileResult));
        }
    }
}
