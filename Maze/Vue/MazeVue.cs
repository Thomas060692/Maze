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

            int current_col = 0;
            int current_row = 0;
            foreach (var item in model)
            {
                while (item.Key.Line > current_row)
                {
                    Console.WriteLine();
                    current_row++;
                    current_col = 0;
                }

                while (item.Key.Column > current_col)
                {
                    Console.Write("  ");
                    current_col++;
                }

                Console.Write($"{item.Value.Symbole} ");
                current_col++;
            }
        }
    }
}
