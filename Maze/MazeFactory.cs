using Maze.Model;

namespace Maze
{
    internal class MazeFactory
    {
        public MazeModel CreateMaze(string name)
        {
            return new MazeModel(name);
        }
    }
}
