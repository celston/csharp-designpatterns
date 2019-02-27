using System.Collections.Generic;

namespace DesignPatterns.Builder.Classic
{
    public class Maze
    {
        private Dictionary<int, Room> _rooms = new Dictionary<int, Room>();

        public Room RoomNo(int room)
        {
            if (!_rooms.ContainsKey(room))
            {
                return null;
            }

            return _rooms[room];
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room.Number, room);
        }
    }
}
