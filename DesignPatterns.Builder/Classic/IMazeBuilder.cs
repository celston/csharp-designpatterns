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
