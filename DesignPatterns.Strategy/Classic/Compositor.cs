using System.Collections.Generic;

namespace DesignPatterns.Strategy.Classic
{
    public abstract class Compositor
    {
        public abstract int Compose(IEnumerable<Coord> natural, IEnumerable<Coord> stretch, IEnumerable<Coord> shrink, int componentCount, int lineWidth, IEnumerable<int> breaks);

        protected Compositor()
        {
        }
    }
}
