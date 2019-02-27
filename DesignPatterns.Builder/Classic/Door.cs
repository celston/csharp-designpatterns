namespace DesignPatterns.Builder.Classic
{
    public class Door
    {
        private Room r1;
        private Room r2;

        public Door()
        {
        }

        public Door(Room r1, Room r2)
        {
            this.r1 = r1;
            this.r2 = r2;
        }
    }
}