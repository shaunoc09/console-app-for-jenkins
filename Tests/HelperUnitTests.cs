using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsConsoleApp.Core.Helper;

namespace Tests
{
    [TestClass]
    public class HelperUnitTests
    {

        [TestMethod]
        public void EmptyStringShouldReturnTrue()
        {
            Helper helper = new Helper();
            Assert.AreEqual(true, helper.IsEmpty(string.Empty));
        }

        [TestMethod]
        public void NoneEmptyStringShouldReturnFalse()
        {
            Helper helper = new Helper();
            Assert.AreEqual(false, helper.IsEmpty("Test"));
        }
    }
}
