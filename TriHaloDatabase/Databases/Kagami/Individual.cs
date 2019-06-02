using System;
using System.Collections.Generic;
using System.Text;

namespace TriHaloDatabase.Databases.Kagami
{
    public class Individual
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual int ParentsID { get; set; }
    }
}
