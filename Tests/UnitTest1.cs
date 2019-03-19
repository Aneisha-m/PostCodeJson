using System;
using NUnit.Framework;

namespace PostCodeJsonTest
{
    [TestFixture]
    public class UnitTest1
    {
        PostcodeService postcodeService = new PostcodeService();
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(200, postcodeService.postCodeDTO.status);
        }
    }
}
