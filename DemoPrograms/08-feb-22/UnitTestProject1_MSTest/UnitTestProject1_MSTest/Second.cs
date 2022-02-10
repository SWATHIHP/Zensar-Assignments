using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTestProject1_MSTest
{
    [TestClass]
    public class Second
    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext tc)
        {
            Trace.WriteLine("Before Assembly");
        }

        [AssemblyCleanup]
        public static void AfterAssembly()
        {
            Trace.WriteLine("After Assembly");
        }
        public void secondclassMethod()
        {
            Trace.WriteLine("Method 1 of second class");
        }

    }
}
