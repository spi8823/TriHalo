using System;
using System.Collections.Generic;
using System.Text;

namespace TriHalo.Common.Tsurugi
{
    public class Sentence
    {
        public int ID { get; set; }
        public Chapter Parent { get; set; }
        public int Number { get; set; }
        public Text Text { get; set; }
    }
}
