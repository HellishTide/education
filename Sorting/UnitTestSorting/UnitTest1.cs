using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;
using System;

namespace UnitTestSorting
{
    [TestClass]
    public class SortingTests
    {
        private static readonly int[] array = { 3, 5, 2, 10, 7 };
        private readonly Sort sort = new Sort();

        [TestMethod]
        public void FindMinIndex_Of_0Index()
        {
            // arange
            int expected = 2;
            int index = 0;

            // act
            int res = sort.FindMinIndex(array, index);

            // assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void FindMinIndex_Of_3Index()
        {
            // arange
            int expected = 4;
            int index = 3;

            // act
            int res = sort.FindMinIndex(array, index);

            // assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void FindMinIndex_ExceptionIndexOutOfRangeException()
        {
            // arange
            int index = 5;

            // act
            void act() => sort.FindMinIndex(array, index);

            // assert
            Assert.ThrowsException<IndexOutOfRangeException>(act);
        }

        [TestMethod]
        public void SwapIndex_2And5_To5And2()
        {
            // arange
            int x = 2;
            int y = 5;
            int exceptedX = 5;
            int expectedY = 2;

            // act
            sort.SwapIndex(ref x, ref y);

            // assert
            if (x == exceptedX && y == expectedY)
                Assert.IsTrue(true);
            else
                Assert.Fail();
        }

        [TestMethod]
        public void SelectionSort_IsSorted()
        {
            // arange
            int[] expected = { 2, 3, 5, 7, 10 };

            // act
            int[] res = sort.SelectionSort(array);

            // assert
            CollectionAssert.AreEqual(expected, res);
        }
    }
}
