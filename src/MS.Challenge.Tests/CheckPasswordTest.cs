using Microsoft.VisualStudio.TestTools.UnitTesting;
using MS.Challenge.CrossCutting.Framework.Helpers;

namespace MS.Challenge.Tests
{
    [TestClass]
    public class CheckPasswordTest
    {
        [TestMethod]
        public void CheckPassword_ShouldReturnTrue()
        {
            Assert.IsTrue(PasswordHelper.IsValid("AbTp9!fok"));
            Assert.IsTrue(PasswordHelper.IsValid("AbTp9!fok@"));
            Assert.IsTrue(PasswordHelper.IsValid("AbTp9!fok+"));
            Assert.IsTrue(PasswordHelper.IsValid("AbTp9!fok-"));
        }

        [TestMethod]
        public void CheckPassword_ShouldReturnFalse()
        {
            Assert.IsFalse(PasswordHelper.IsValid(""));
            Assert.IsFalse(PasswordHelper.IsValid("aa"));
            Assert.IsFalse(PasswordHelper.IsValid("ab"));
            Assert.IsFalse(PasswordHelper.IsValid("AAAbbbCc"));
            Assert.IsFalse(PasswordHelper.IsValid("AbTp9!foo"));
            Assert.IsFalse(PasswordHelper.IsValid("AbTp9!foA"));
            Assert.IsFalse(PasswordHelper.IsValid("AbTp9 fok"));
        }
    }
}
