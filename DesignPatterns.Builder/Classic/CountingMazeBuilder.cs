namespace DesignPatterns.Builder.Classic
{
    public class CountingMazeBuilder : IMazeBuilder
    {
        private StandardMazeBuilder _subBuilder = new StandardMazeBuilder();

        public int Rooms { get; private set; }
        public int Doors { get; private set; }

        public void BuildDoor(int roomFrom, int roomTo)
        {
            Doors++;
            _subBuilder.BuildDoor(roomFrom, roomTo);
        }

        public void BuildMaze()
        {
            _subBuilder.BuildMaze();
        }

        public void BuildRoom(int room)
        {
            Rooms++;
            _subBuilder.BuildRoom(room);
        }

        public Maze GetMaze()
        {
            return _subBuilder.GetMaze();
        }
    }
}
