using KST.Manager.Implementation;
using KST.Manager.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace KST.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DeploymentItem(@"KST.Tests\TestFiles\unsorted-names-list.txt", "ssest")]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
