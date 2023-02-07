using JWTWebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace JWTWebApi.Context
{
    public class JWTDbContext : DbContext

    {
        public JWTDbContext(DbContextOptions<JWTDbContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
