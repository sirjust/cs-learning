using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion4
{
    public class NUnitTestClass
    {
        [TestFixture]
        public class SolutionTest
        {
            private static object[] Test_Cases = new object[]
            {
                new object[] {1234, [1,2,3,4]};
                new object[] {57290, [5,7,2,9,0] };
                new object[] {0, [0] };
            };
            [Test, TestCaseSource(typeof(SolutionTest), "Test_Cases")]
            public void Basic_Test(int test, int[] expected)
        {
            Assert.AreEqual(expected, displayDigits.)
        }
        }



    }
}
