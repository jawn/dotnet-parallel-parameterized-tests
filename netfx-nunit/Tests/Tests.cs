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
        [Test]
        public void TestThreeSeconds()
        {
            SimulateSlowTest(3);
        }

        [Test]
        public void TestFiveSeconds()
        {
            SimulateSlowTest(5);
        }

        [Test]
        public void TestSevenSeconds()
        {
            SimulateSlowTest(7);
        }

        private static void SimulateSlowTest(int testDurationInSeconds)
        {
            int milliseconds = testDurationInSeconds * 1000;

            // Simulate actual test work
            Thread.Sleep(milliseconds);
        }
    }
}
