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
            int actual = sort.FindMinIndex(array, index);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMinIndex_Of_3Index()
        {
            // arange
            int expected = 4;
            int index = 3;

            // act
            int actual = sort.FindMinIndex(array, index);

            // assert
            Assert.AreEqual(expected, actual);
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
        public void Swap_2And5_To5And2()
        {
            // arange
            int x = 2;
            int y = 5;
            int exceptedX = 5;
            int expectedY = 2;

            // act
            sort.Swap(ref x, ref y);

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
            int[] actual = sort.SelectionSort(array);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuickSort_0Elem()
        {
            // arange
            int[] array = new int[0];
            int[] expected = { };

            // act
            int[] actual = sort.QuickSort(array);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuickSort_1Elem()
        {
            // arange
            int[] array = new int[1];
            int[] expected = { 0 };

            // act
            int[] actual = sort.QuickSort(array);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuickSort_2Elem()
        {
            // arange
            int[] array = new int[2];
            int[] expected = new int[2];

            // act
            int[] actual = sort.QuickSort(array);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuickSort_IsSorted()
        {
            // arange
            int[] expected = { 2, 3, 5, 7, 10 };

            // act
            int[] actual = sort.QuickSort(array);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuickSort_IsSortedWithDuplicates()
        {
            // arange
            int[] example  = { 3, 7, 13, 5, 2, 11, 2, 13, 10 };
            int[] expected = { 2, 2, 3, 5, 7, 10, 11, 13, 13 };

            // act
            int[] actual = sort.QuickSort(example);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
