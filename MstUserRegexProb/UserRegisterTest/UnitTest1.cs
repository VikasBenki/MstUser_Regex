using Microsoft.VisualStudio.TestTools.UnitTesting;
using MstUserRegexProb;
using System;

namespace UserRegisterTest
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateFirstName("Saurav");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestFirstName_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateFirstName("Sa");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateFirstName("saurav");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        public void TestLastName_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateLastName("Kumar");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestLastName_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateLastName("Ka");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateLastName("kumar");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        public void TestEmailID_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateEmailID("saurav@gmail.co.in");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestEmailID_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateEmailID("saurav.kr@g.in");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateEmailID(".kr@gmail.com.in");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        public void TestMobileNumber_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateMobileNumber("91 7067845485");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestMobileNumber_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateMobileNumber("7067845485");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateMobileNumber("23 7067845485");
            Assert.AreEqual(excepted, actual1);
            var actual2 = UserRegister.ValidateMobileNumber("91 70678454858");
            Assert.AreEqual(excepted, actual2);
        }
        [TestMethod]
        public void TestPassword_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidatePassword("SauGav76@#$");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestPassword_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidatePassword("S9a@#$j");
            Assert.AreEqual(excepted, actual);
        }
    }
}
