
using NUnit.Framework;
using System.IO;
using System;

namespace HelloWorldTests
{
    public class Tests
    {
        private const string ExpectedTest1 = "Test1";
        private const string ExpectedTest2 = "Test2";
        private const string ExpectedTest3 = "Test3";

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
                DavidApp.Program.TestMethod1();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedTest1, result);
            }
        }
        [Test]
        public void TestMethod2()
        {
            
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                DavidApp.Program.TestMethod2();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedTest2, result);
            }
        //    var testMethod = TestMethod2();
        }
        public void TestMethod3()
        {
            
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                DavidApp.Program.TestMethod3();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedTest3, result);
            }
        //    var testMethod = TestMethod2();
        }
    }
}
