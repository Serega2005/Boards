using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards
{
    public class MarkerBoard : Board, IWritingAffiliation
    {
        public string WritingAffiliation { get; set; }
        private string Marker { get; set; }
        public MarkerBoard() { }
        public MarkerBoard(double size, string Convenience, string writingaffiliation)
        {
            WritingAffiliation = writingaffiliation;
        }
    }
}
