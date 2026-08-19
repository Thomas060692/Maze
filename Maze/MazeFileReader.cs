using Maze.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maze
{
    internal class MazeFileReader
    {
        delegate void ElementRead(int row, int column);

        IMazeBuilder _builder;
        Dictionary<char, ElementRead> elementsReader = new();

        public MazeFileReader(IMazeBuilder builder)
        {
            _builder = builder;
            elementsReader['.'] = (r, c) => _builder.AddRoom(r, c);
            elementsReader['*'] = (r, c) => _builder.AddWall(r, c);
        }

        public void Read(string name)
        {
            string file = name + ".maze";

            string line;
            try
            {
                StreamReader sr = new StreamReader(@$"C:\Users\m-y-w\source\repos\Maze\Maze\File\{file}");

                _builder.Start(name);

                line = sr.ReadLine();

                for (int row = 0; line != null; row++)
                {                    
                    for(int col = 0; col < line.Length; col++)
                    {
                        if (elementsReader.ContainsKey(line[col]))
                        {
                            elementsReader[line[col]](row, col);
                        }
                    }

                    line = sr.ReadLine();
                }

                sr.Close();
                _builder.Finish();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}