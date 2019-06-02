using System;
using System.Collections.Generic;
using System.Text;

namespace TriHaloDatabase.Databases.Kagami
{
    public class Couple
    {
        public virtual int ID { get; set; }
        public virtual int MaleID { get; set; }
        public virtual int FemaleID { get; set; }
    }
}
