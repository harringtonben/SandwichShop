using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich.App
{
    public class SandwichSelectionScreen
    {
        Sandwhich _sandwhich = new Sandwhich();

        public void AddTomatoes(int numberOfTomoatoes)
        {
            _sandwhich.Tomatoes += numberOfTomoatoes;
        }

        public Sandwhich BuildSandwich()
        {
            return _sandwhich;
        }

        public void AddOnions()
        {
            _sandwhich.Onions = true;
        }
    }

    public class Sandwhich
    {
        public int Tomatoes { get; set; }
        public bool Onions { get; set; }
    }
}
