namespace DesignPatterns.Builder.Classic
{
    public class Direction
    {
        public static Direction North = new Direction();
        public static Direction South = new Direction();
        public static Direction East = new Direction();
        public static Direction West = new Direction();

        protected Direction()
        {
        }
    }
}
