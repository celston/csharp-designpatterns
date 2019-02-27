using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy.Classic
{
    public class TeXCompositor : Compositor
    {
        public override int Compose(IEnumerable<Coord> natural, IEnumerable<Coord> stretch, IEnumerable<Coord> shrink, int componentCount, int lineWidth, IEnumerable<int> breaks)
        {
            throw new NotImplementedException();
        }
    }
}
