using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BrainFuckLib;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRunningExecuteMethod()
        {
            Assert.ThrowsException<NotImplementedException>(() => {
                string output = BrainFuck.Execute("Code", "Input"); 
            });
        }
    }
}
