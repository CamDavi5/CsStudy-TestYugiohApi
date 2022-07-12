using Microsoft.EntityFrameworkCore;

namespace TestYugiohApi.Models
{
    public class YugiohContext : DbContext
    {
        public YugiohContext(DbContextOptions<YugiohContext> options)
            : base(options)
        { 
        }

        public DbSet<YugiohCard> YugiohCards { get; set; }
    }
}
