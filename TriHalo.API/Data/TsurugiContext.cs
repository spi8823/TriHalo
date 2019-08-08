﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TriHalo.Common.Tsurugi;
using TriHalo.Common;

namespace TriHalo.API.Models
{
    public class TsurugiContext : DbContext
    {
        public TsurugiContext()
        {

        }
        public TsurugiContext (DbContextOptions<TsurugiContext> options)
            : base(options)
        {
        }

        public DbSet<TriHalo.Common.Tsurugi.Book> Book { get; set; }
    }
}
