using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards
{
    public abstract class Board
    {
        public double Size { get; set; }
        public string Convenience { get; set; }
        protected Board() { }
        protected Board(double size, string convenience)
        {
            Size = size;
            Convenience = convenience;
        }
    }
}
