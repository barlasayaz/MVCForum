using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCForum.Domain
{
    public class Probabilities
    {
        public int FTHomeWin { get; set; }
        public int FTDraw { get; set; }
        public int FTAwayWin { get; set; }
        public int HTHomeWin { get; set; }
        public int HTDraw { get; set; }
        public int HTAwayWin { get; set; }
        public int OverTwoAndHalf { get; set; }
        public int OverOneAndHalf { get; set; }
        public int OverThreeAndHalf { get; set; }
    }
}