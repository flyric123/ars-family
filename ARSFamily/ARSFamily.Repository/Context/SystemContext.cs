using ARSFamily.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARSFamily.Repository.Context
{
    public class SystemContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public SystemContext() : base("DBARSFamily") { }
    }
}
