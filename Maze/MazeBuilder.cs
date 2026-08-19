using Maze.Interface;
using Maze.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maze
{
    internal class MazeBuilder : IMazeBuilder
    {
        MazeModel mod;

        public MazeModel Build()
        {
            return mod;
        }

        public void AddRoom(int line, int column)
        {
            mod[new MazePosition(line, column)] =  new Room();
        }

        public void AddWall(int line, int column)
        {
            mod[new MazePosition(line, column)] = new Wall();
        }

        public void Finish()
        {
            
        }

        public void Start(string name)
        {
            mod = new MazeModel(name);
        }
    }
}
