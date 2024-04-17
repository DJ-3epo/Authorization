using Authorization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void AuthTest()
        {
            var page = new AuthPage();
            Assert.IsTrue(page.Auth("Elizor@gmai.com","yntiRS")); 
            Assert.IsFalse(page.Auth("user1", "12345")); 
            Assert.IsFalse(page.Auth("", ""));
            Assert.IsFalse(page.Auth(" "," "));
        }
    }
}
