
using NUnit.Framework;
using System.IO;
using System;

namespace HelloWorldTests
{
    public class Tests
    {
        private const string ExpectedTest1 = "David App Test";
        
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                DavidApp.Program.DavidTestMEthod();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedTest1, result);
            }
        }
        [Test]
        public void TestMethod2()
        {
        //    var testMethod = TestMethod2();
        }
    }
}