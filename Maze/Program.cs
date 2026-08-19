using Maze.Controler;
using Maze.Model;
using Maze.Vue;

namespace Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MazeFactory factory = new MazeFactory();

            MazeModel mod = factory.CreateMaze("premier labyrinthe");
            MazeVue view = new MazeVue(); 

            MazeControler controler = new MazeControler();

            controler.Model = mod;
            controler.Vue = view;

            controler.Start();
        }
    }
}
