using System;

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
            var r1 = _currentMaze.RoomNo(roomFrom);
            var r2 = _currentMaze.RoomNo(roomTo);
            var door = new Door(r1, r2);

            r1.SetSide(CommonWall(r1, r2), door);
            r2.SetSide(CommonWall(r1, r2), door);
        }

        public void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public void BuildRoom(int n)
        {
            if (_currentMaze == null) return;
            if (_currentMaze.RoomNo(n) != null) return;

            var room = new Room(n);
            _currentMaze.AddRoom(room);

            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.West, new Wall());
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
