using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PBS;

namespace PBSTest
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subject = new Model();
            Assert.AreEqual("Jim", subject.Name);
        }
    }
}
