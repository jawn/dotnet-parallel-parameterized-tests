using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        public void TestSimulateNumberOfSeconds(int testDurationInSeconds)
        {
            SimulateSlowTest(testDurationInSeconds);
        }
        
        private static void SimulateSlowTest(int testDurationInSeconds)
        {
            int milliseconds = testDurationInSeconds * 1000;

            // Simulate actual test work
            Thread.Sleep(milliseconds);
        }
    }
}
