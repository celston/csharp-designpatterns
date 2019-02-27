using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Classic
{
    public interface IMazeBuilder
    {
        void BuildMaze();
        void BuildRoom(int room);
        void BuildDoor(int roomFrom, int roomTo);

        Maze GetMaze();
    }
}
