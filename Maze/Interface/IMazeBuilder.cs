using System;
using System.Collections.Generic;
using System.Text;

namespace Maze.Interface
{
    internal interface IMazeBuilder
    {
        public void Start(string name);
        public void AddRoom(int line, int column);
        public void AddWall(int line, int column);
        public void Finish();
    }
}
