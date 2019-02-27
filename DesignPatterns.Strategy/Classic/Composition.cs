using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy.Classic
{
    public class Composition
    {
        private Compositor _compositor;
        private List<Component> _components;
        private int _lineWidth;
        private List<int> _lineBreaks;
        private int _lineCount;

        public Composition(Compositor compositor)
        {
            _compositor = compositor;
        }

        public void Repair()
        {
            var natural = new List<Coord>();
            var strechability = new List<Coord>();
            var shrinkability = new List<Coord>();
            var componentCount = 0;
            var breaks = new List<int>();

            // prepare the arrays with the desired component sizes
            // ...

            // determine where the breaks are
            int breakCount = _compositor.Compose(natural, strechability, shrinkability, componentCount, _lineWidth, breaks);

            // lay out components according to breaks
            // ...
        }
    }
}
