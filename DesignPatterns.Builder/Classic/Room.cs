using System;

namespace DesignPatterns.Builder.Classic
{
    public class Room
    {
        public Room(int number)
        {
            Number = number;
        }

        public int Number { get; private set; }

        public void SetSide(Direction north, Wall wall)
        {
            throw new NotImplementedException();
        }

        public void SetSide(Direction direction, Door door)
        {
            throw new NotImplementedException();
        }
    }
}