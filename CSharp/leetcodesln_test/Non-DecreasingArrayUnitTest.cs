using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class Non_DecreasingArrayUnitTest
    {
        public Non_DecreasingArray Non_DecreasingArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            Non_DecreasingArray = new Non_DecreasingArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 4, 2, 3 };
            var expected = true;
            var actual = Non_DecreasingArray.CheckPossibility(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 4, 2, 1 };
            var expected = false;
            var actual = Non_DecreasingArray.CheckPossibility(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 3, 4, 2, 3 };
            var expected = false;
            var actual = Non_DecreasingArray.CheckPossibility(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new int[] { -1, 4, 2, 3 };
            var expected = true;
            var actual = Non_DecreasingArray.CheckPossibility(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var input = new int[] { 2, 3, 3, 2, 4 };
            var expected = true;
            var actual = Non_DecreasingArray.CheckPossibility(input);
            Assert.AreEqual(expected, actual);
        }
    }
}