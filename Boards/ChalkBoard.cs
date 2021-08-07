using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards
{
    public class ChalkBoard : Board, IWritingAffiliation
    {
        public string WritingAffiliation { get; set; }
        private string Chalk { get; set; }

        public ChalkBoard() { }
        public ChalkBoard(double size, string Convenience, string writingaffiliation)
        {
            WritingAffiliation = writingaffiliation;
        }
    }
}
