
using Maze.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Maze.Model
{
    internal class MazeModel : IEnumerable<KeyValuePair<MazePosition,IMazeElement>>
    {
        public string Name { get; }

        public IMazeElement this[MazePosition pos] 
        {
            get { return this[pos]; }
            set => grid.Add(pos, value);
        }

        SortedDictionary<MazePosition, IMazeElement> grid = new();

        public MazeModel(string name)
        {
            Name = name;
        }

        public IEnumerator<KeyValuePair<MazePosition, IMazeElement>> GetEnumerator()
        {
            foreach (var item in grid)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
