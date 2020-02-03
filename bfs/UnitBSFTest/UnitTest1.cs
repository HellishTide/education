using Microsoft.VisualStudio.TestTools.UnitTesting;
using bfs;
using System.Collections.Generic;
using System;

namespace UnitBSFTest
{
    [TestClass]
    public class UnitBFSTest
    {
        private readonly Bfs bfs = new Bfs();

        [TestMethod]
        public void BSFTest_AddToQueueSuccess()
        {
            // arange
            List<string> list_you = new List<string>{ "alice", "bob", "claire" };
            List<string> list_alice = new List<string>{ "dad", "bob" };
            List<string> list_bob = new List<string>{ "alice", "kent" };
            List<string> key_store = new List<string> { "you", "alice", "bob" };

            int expected = 7;

            // act

            // fill dictionary
            bfs.DictionaryGraph.Add(key_store[0], list_you);
            bfs.DictionaryGraph.Add(key_store[1], list_alice);
            bfs.DictionaryGraph.Add(key_store[2], list_bob);

            // fill queue
            foreach (string element in key_store)
                bfs.AddToQueue(element);

            int actual = bfs.SearchQueue.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BFSTest_AddToQueueArgumentOutOfRangeException()
        {
            // arange
            List<string> list = new List<string>();

            // act
            void act() => bfs.AddToQueue(list[0]);

            // assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(act);
            
        }

        [TestMethod]
        public void BFSTest_SearchArgumentNullException()
        {
            // arange
            List<string> key_store = new List<string> { "you", "alice", "bob" };
            List<string> list_you = new List<string> { "alice", "bob", "claire" };

            // act
            void act() => bfs.Bfs_Search(list_you[0]);

            // assert
            Assert.ThrowsException<ArgumentNullException>(act);
            
        }

        [TestMethod]
        public void BFSTest_SearchFound()
        {
            // arange
            List<string> list_you = new List<string> { "alice", "bob", "claire" };
            List<string> list_alice = new List<string> { "dad", "bob" };
            List<string> list_bob = new List<string> { "alice", "kent" };
            List<string> key_store = new List<string> { "you", "alice", "bob" };

            string expected = "Find kent";

            // act
            // fill dictionary
            bfs.DictionaryGraph.Add(key_store[0], list_you);
            bfs.DictionaryGraph.Add(key_store[1], list_alice);
            bfs.DictionaryGraph.Add(key_store[2], list_bob);

            // fill queue
            foreach (string element in key_store)
                bfs.AddToQueue(element);

            string actual = bfs.Bfs_Search(key_store[0]);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BFSTest_SearchNotFound()
        {
            // arange
            List<string> list_you = new List<string> { "alice", "bob", "claire" };
            List<string> list_alice = new List<string> { "dad", "bob" };
            List<string> list_bob = new List<string> { "alice", "kents" };
            List<string> key_store = new List<string> { "you", "alice", "bob" };

            string expected = "Not found";

            // act
            // fill dictionary
            bfs.DictionaryGraph.Add(key_store[0], list_you);
            bfs.DictionaryGraph.Add(key_store[1], list_alice);
            bfs.DictionaryGraph.Add(key_store[2], list_bob);

            string actual = bfs.Bfs_Search(key_store[0]);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
