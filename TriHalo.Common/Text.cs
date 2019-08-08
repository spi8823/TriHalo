using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TriHalo.Common
{
    [Owned]
    public class Text
    {
        public string Original { get; set; }
        public string Ruby { get; set; }
    }
}
