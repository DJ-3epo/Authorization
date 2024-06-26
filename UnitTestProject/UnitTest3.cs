﻿using Authorization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void AuthTestSuccess()
        {
            var page = new AuthPage();
            Assert.IsTrue(page.Auth("Elizor@gmai.com", "yntiRS"));
            Assert.IsTrue(page.Auth("Vladlena@gmai.com", "07i7Lb"));
            Assert.IsTrue(page.Auth("Adam@gmai.com", "7SP9CV"));
            Assert.IsTrue(page.Auth("Kar@gmai.com", "6QF1WB"));
            Assert.IsTrue(page.Auth("Yli@gmai.com", "GwffgE"));
            Assert.IsTrue(page.Auth("Vasilisa@gmai.com", "d7iKKV"));
            Assert.IsTrue(page.Auth("Galina@gmai.com", "8KC7wJ"));
            Assert.IsTrue(page.Auth("Miron@gmai.com", "x58OAN"));
            Assert.IsTrue(page.Auth("Vseslava@gmai.com", "fhDSBf"));
            Assert.IsTrue(page.Auth("Victoria@gmai.com", "9mlPQJ"));
            Assert.IsTrue(page.Auth("Anisa@gmai.com", "Wh4OYm"));
            Assert.IsTrue(page.Auth("Feafan@gmai.com", "Kc1PeS"));
        }
    }
}
