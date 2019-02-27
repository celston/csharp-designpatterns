using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy.Classic
{
    public class ArrayCompositor : Compositor
    {
        private int _interval;

        public ArrayCompositor(int interval)
        {
            _interval = interval;
        }

        public override int Compose(IEnumerable<Coord> natural, IEnumerable<Coord> stretch, IEnumerable<Coord> shrink, int componentCount, int lineWidth, IEnumerable<int> breaks)
        {
            throw new NotImplementedException();
        }
    }
}
