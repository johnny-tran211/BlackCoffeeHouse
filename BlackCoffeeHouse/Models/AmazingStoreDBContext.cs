using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlackCoffeeHouse.Models
{
    public class AmazingStoreDBContext: DbContext
    {
        public AmazingStoreDBContext(DbContextOptions<AmazingStoreDBContext> options) : base(options)
        {

        }
        public DbSet<Registration> Registration { get; set; }
    }
}
