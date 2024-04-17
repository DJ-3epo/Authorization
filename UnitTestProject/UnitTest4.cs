using Authorization;


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void RegistrationTestSuccess()
        {
            var page = new RegPage();
            Assert.IsTrue(page.Register("John Doe", "john.doe@example.com", "password123", "Пользователь"));
        }

        [TestMethod]
        public void RegistrationTestFail_EmptyFields()
        {
            var page = new RegPage();
            Assert.IsFalse(page.Register("", "", "", ""));
        }
    }
}
