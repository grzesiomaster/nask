using Microsoft.EntityFrameworkCore;
using NASK.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NASK.Domain
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.Migrate();
        }
        public DbSet<StoredDocument> Documents { get; set; }
    }
}
