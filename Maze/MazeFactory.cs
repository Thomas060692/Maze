using Maze.Model;

namespace Maze
{
    internal class MazeFactory
    {
        public MazeModel CreateMaze(string name)
        {
            MazeBuilder builder = new MazeBuilder();
            MazeFileReader mReader = new MazeFileReader(builder);

            mReader.Read(name);

            return builder.Build();
        }
    }
}
