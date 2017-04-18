using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsConsoleApp.Core.Helper;

namespace JenkinsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Helper helper = new Helper();
            Assert.AreEqual(true, helper.IsEmpty(string.Empty));
        }
    }
}
