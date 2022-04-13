using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTest.AlgorithmsTests
{
    public static class BFSTestt
    {
        [Fact]
        public static void Test()
        {
            BreadthFirstSearch.Node tree = BreadthFirstSearch.SampleTree();
            Console.WriteLine("BFS->");
            BreadthFirstSearch.BFS(tree);
        }
    }
}