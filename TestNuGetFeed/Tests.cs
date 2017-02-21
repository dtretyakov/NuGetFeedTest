using System;
using NUnit.Framework;

namespace TestNuGetFeed
{
    [TestFixture]
    public class TestLocalTeamCityFeed
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual(5, NuGetFeedTest.Calculator.Plus(3, 4));
        }
    }
}
