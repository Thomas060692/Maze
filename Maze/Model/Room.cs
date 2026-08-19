using Maze.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maze.Model
{
    internal class Room : IMazeElement
    {
        public char Symbole { get; } = '.';
    }
}
