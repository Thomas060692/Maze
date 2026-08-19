using System;
using System.Collections.Generic;
using System.Text;

namespace Maze
{
    internal class MazePosition : IComparable<MazePosition>
    {
        public int Line { get; private set; }
        public int Column { get; private set; }

        public MazePosition(int line, int column)
        {
            Line = line;
            Column = column;
        }

        public int CompareTo(MazePosition? other)
        {
            if (this.Line < other.Line)
            {
                return -1;
            }
            else if (this.Line > other.Line)
            {
                return 1;
            }
            else if (this.Column < other.Column)
            {
                return -1;
            }
            else if (this.Column > other.Column)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is MazePosition position &&
                   Line == position.Line &&
                   Column == position.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Line, Column);
        }

        public override string ToString()
        {
            return $"{Line} , {Column}";
        }
    }
}
