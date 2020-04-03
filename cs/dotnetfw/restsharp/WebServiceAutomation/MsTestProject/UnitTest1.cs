using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("MyOptionalTestCategory")]
        public void TestMethod1()
        {
            Console.WriteLine("TestMethod1...");
        }

        [TestMethod]
        [Ignore] // Skip this method
        public void TestMethod2()
        {
            Console.WriteLine("TestMethod1...");
        }

        [TestInitialize]
        public void Setup()
        {
            Console.WriteLine("Setup...");
        }

        [TestCleanup]
        public void TearDown()
        {
            Console.WriteLine("TearDown...)");
        }

        [ClassInitialize] 
        public static void ClassSetup(TestContext textContext) // Executes only once
        {
            Console.WriteLine("ClassSetup...");
        }

        [ClassCleanup] 
        public static void ClassTearDown() // Executes only once
        {
            Console.WriteLine("ClassTearDown...");
        }

        [AssemblyInitialize]
        public static void AssemblySetup(TestContext testContext)
        {
            Console.WriteLine("AssemblySetup...");
        }

        [AssemblyCleanup]
        public static void AssemblyTearDown()
        {
            Console.WriteLine("AssemblyTearDown...");
        }
    }
}
