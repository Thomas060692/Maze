using Maze.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maze.Model
{
    internal class Wall : IMazeElement
    {
        public char Symbole { get; } = '*';
    }
}
