using Microsoft.VisualStudio.TestTools.UnitTesting;
using binary_search;

namespace UnitTestBinarySearch
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void BinSearch_FindFive()
        {
            // arange
            int[] ar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int expected = 5;
            int num = 5;
            BinSearch bs = new BinSearch();

            // act
            int res = int.Parse(bs.search(ar, num));

            // assert
            Assert.AreEqual(expected, res, "Not equal");
        }

        [TestMethod]
        public void BinSearch_NotFind()
        {
            // arange
            int[] ar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string expected = "None";
            int num = 10;
            BinSearch bs = new BinSearch();

            // act
            string res = bs.search(ar, num);

            // assert
            Assert.AreEqual(expected, res, "Not equal");
        }

        [TestMethod]
        public void BinSearch_EmptyArr()
        {
            // arange
            int[] ar = { };
            int find = 4;

            string expected = "None";
            BinSearch bs = new BinSearch();

            // act
            string res = bs.search(ar, find);

            // assert
            Assert.AreEqual(expected, res, "Not equal");
        }
    }
}
