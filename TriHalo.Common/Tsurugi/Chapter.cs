using System;
using System.Collections.Generic;
using System.Text;

namespace TriHalo.Common.Tsurugi
{
    public class Chapter
    {
        public int ID { get; set; }
        public Book Parent { get; set; }
        public int Number { get; set; }
        public Text Title { get; set; }
        public string ReferenceURL { get; set; }
        public List<Sentence> Sentences { get; set; }
    }
}
