using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooApplication.Modle
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<UserModle> User { get; set; }
    }
}
