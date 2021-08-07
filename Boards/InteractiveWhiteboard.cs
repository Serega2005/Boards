using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards
{
    //  Описание доскок
    class InteractiveWhiteboard : Board, IWritingAffiliation
    {
        public string WritingAffiliation { get; set; }
        private string LaseкPointer { get; set; }
        public InteractiveWhiteboard() { }
        public InteractiveWhiteboard(double size, string Convenience, string writingaffiliation)
        {
            WritingAffiliation = writingaffiliation;
        }
    }
}
