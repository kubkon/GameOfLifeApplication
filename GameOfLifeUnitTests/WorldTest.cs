using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLifeApplication;

namespace GameOfLifeUnitTests
{
    [TestClass]
    public class WorldTest
    {
        static World world;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            var initCells = new List<int[]>() {
                new int[] {0, 0},
                new int[] {1, 1}
            };
            world = new World(2, 2, 2, initCells: initCells);
        }

        [TestMethod]
        public void TestCountLiveNeighbours()
        {
            var live = world.CountLiveNeighbours(0, 0);
            Assert.AreEqual(1, live);
            live = world.CountLiveNeighbours(0, 1);
            Assert.AreEqual(2, live);
            live = world.CountLiveNeighbours(1, 0);
            Assert.AreEqual(2, live);
            live = world.CountLiveNeighbours(1, 1);
            Assert.AreEqual(1, live);
        }

        [TestMethod]
        public void TestApplyRules()
        {
            int x = 0, y = 0;
            var live = world.CountLiveNeighbours(x, y);
            var future = world.ApplyRules(world.Grid[x, y], live);
            Assert.AreEqual(World.State.Dead, future);
            x = 0;
            y = 1;
            live = world.CountLiveNeighbours(x, y);
            future = world.ApplyRules(world.Grid[x, y], live);
            Assert.AreEqual(World.State.Dead, future);
        }

        [TestMethod]
        public void TestEvolve()
        {
            var initCells = new List<int[]>() {
                new int[] {0, 1},
                new int[] {1, 2},
                new int[] {2, 0},
                new int[] {2, 1},
                new int[] {2, 2}
            };
            var w = new World(4, 4, 2, initCells: initCells);
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(false, w.Evolve());
            }
            Assert.AreEqual(true, w.Evolve());
            for (int i = 0; i < w.Rows; i++)
            {
                for (int j = 0; j < w.Columns; j++)
                {
                    var cell = w.Grid[i, j];
                    if ((i == 2 || i == 3) && (j == 2 || j == 3))
                        Assert.AreEqual(World.State.Live, cell);
                    else
                        Assert.AreEqual(World.State.Dead, cell);
                }
            }
        }
    }
}
