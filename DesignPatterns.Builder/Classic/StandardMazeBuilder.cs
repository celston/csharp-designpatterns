using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Classic
{
    public class StandardMazeBuilder : IMazeBuilder
    {
        private Maze _currentMaze;

        public StandardMazeBuilder()
        {
            _currentMaze = null;
        }

        public void BuildDoor(int roomFrom, int roomTo)
        {
            throw new NotImplementedException();
        }

        public void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public void BuildRoom(int n)
        {
            if (_currentMaze == null) return;
            if (_currentMaze.RoomNo(n)) return;

            var room = new Room(n);
            _currentMaze.AddRoom(room);

            room.SetSide(North, new Wall());
        }

        public Maze GetMaze()
        {
            return _currentMaze;
        }

        private Direction CommonWall(Room room1, Room room2)
        {
            throw new NotImplementedException();
        }        
    }
}
