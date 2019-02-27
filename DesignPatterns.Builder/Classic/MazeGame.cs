namespace DesignPatterns.Builder.Classic
{
    public class MazeGame
    {
        public Maze CreateMaze(IMazeBuilder builder)
        {
            builder.BuildMaze();

            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            return builder.GetMaze();
        }

        public Maze CreateComplexMaze(IMazeBuilder builder)
        {
            builder.BuildMaze();

            builder.BuildRoom(1);
            // ...
            builder.BuildRoom(1001);

            return builder.GetMaze();
        }
    }
}
