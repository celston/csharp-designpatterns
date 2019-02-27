using Microsoft.VisualStudio.TestTools.UnitTesting;

using DesignPatterns.Builder.Classic;

namespace DesignPatterns.Builder.Tests.Classic
{
    [TestClass]
    public class StandardMazeBuilderTests
    {
        private MazeGame _game = new MazeGame();

        [TestMethod]
        public void CreateMaze_Normal_Success()
        {
            var builder = new StandardMazeBuilder();

            _game.CreateMaze(builder);
            var maze = builder.GetMaze();
        }

        [TestMethod]
        public void CreateComplexMaze_Normal_Success()
        {
            var builder = new StandardMazeBuilder();

            _game.CreateComplexMaze(builder);
            var maze = builder.GetMaze();
        }
    }
}
