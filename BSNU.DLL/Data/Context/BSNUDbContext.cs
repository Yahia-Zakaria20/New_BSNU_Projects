using BSNU.DLL.Data.Enities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSNU.DLL.Data.Context
{
    public class BSNUDbContext : DbContext
    {
        public BSNUDbContext(DbContextOptions<BSNUDbContext> options) : base(options)
        {

        }

        public DbSet<News> News { get; set; }
    }


}
