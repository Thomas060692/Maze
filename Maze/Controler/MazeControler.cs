using Maze.Model;
using Maze.Vue;

namespace Maze.Controler
{
    internal class MazeControler
    {
        public MazeModel Model { get; set; }
        public MazeVue Vue { get; set; }

        public void Start()
        {
            Vue.Display(Model, "vous avez choisi");
        }
    }
}
