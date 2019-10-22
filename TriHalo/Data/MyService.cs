using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TriHalo.Data
{
    public class MyService
    {
        private MyContext _Context { get; }

        public MyService(MyContext context)
        {
            _Context = context;
        }

        public async Task ClearIchinomiyas()
        {
            _Context.Ichinomiyas.RemoveRange(await GetIchinomiyas());
            _Context.SaveChanges();
        }

        public async Task<List<Ichinomiya>> GetIchinomiyas()
        {
            return await _Context.Ichinomiyas.ToListAsync();
        }

        public async Task AddIchinomiya(Ichinomiya ichinomiya)
        {
            await _Context.Ichinomiyas.AddAsync(ichinomiya);
            await _Context.SaveChangesAsync();
        }
    }

    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<Ichinomiya> Ichinomiyas { get; set; }
    }
}
