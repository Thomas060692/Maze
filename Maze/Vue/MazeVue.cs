using Maze.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maze.Vue
{
    internal class MazeVue
    {
        public void Display(MazeModel model, string message)
        {
            Console.WriteLine($"{message} : {model.Name}");
        }
    }
}
