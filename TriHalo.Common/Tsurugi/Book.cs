using System;
using System.Collections.Generic;
using System.Text;

namespace TriHalo.Common.Tsurugi
{
    public class Book
    {
        public int ID { get; set; }
        public Text Title { get; set; }
        public string ReferenceURL { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}
